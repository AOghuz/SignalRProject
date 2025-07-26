using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;                 // DbContext vs.
using SignalR.DataAccessLayer.Concrete;             // SignalRContext
using SignalR.EntityLayer.Entities;                 // AppUser / AppRole

var builder = WebApplication.CreateBuilder(args);
var requireAuthorizePolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();

/*────────────────── 1) SERVICE REGISTRATION ──────────────────*/
builder.Services.AddDbContext<SignalRContext>();

builder.Services.AddIdentity<AppUser, AppRole>()
       .AddEntityFrameworkStores<SignalRContext>();

builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews(opt =>
{
    opt.Filters.Add(new AuthorizeFilter(requireAuthorizePolicy));
});
builder.Services.ConfigureApplicationCookie(opts =>
{
    opts.LoginPath = "/Login/Index";
});

/* ▸ Session için gerekli servisler  (Build'den ÖNCE!) */
builder.Services.AddDistributedMemoryCache();        // Bellek içi cache
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(1);   // Oturum süresi
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

/*────────────────── 2) BUILD ──────────────────*/
var app = builder.Build();
app.UseStatusCodePages(async x =>
{
    if (x.HttpContext.Response.StatusCode == 404)
    {
        x.HttpContext.Response.Redirect("/Error/NotFound404Page/");
    }
});

/*────────────────── 3) MIDDLEWARE PIPELINE ──────────────────*/


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

/* ▸ Session middleware  (Routing'den sonra, Authorization'dan önce) */
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();

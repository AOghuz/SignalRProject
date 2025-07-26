using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using ZXing;
using ZXingImg = ZXing.ImageSharp;

namespace SignalRWebUI.Controllers
{
    public class QRCodeController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Index(string value, IFormFile qrFile, string action)
        {
            // QR KOD OLUŞTUR
            if (action == "generate" && !string.IsNullOrWhiteSpace(value))
            {
                var writer = new ZXingImg.BarcodeWriter<Rgba32>
                {
                    Format = BarcodeFormat.QR_CODE,
                    Options = new ZXing.Common.EncodingOptions
                    {
                        Height = 300,
                        Width = 300,
                        Margin = 1
                    }
                };

                using Image<Rgba32> qr = writer.Write(value);
                using var ms = new MemoryStream();
                qr.SaveAsPng(ms);
                ViewBag.QrCodeImage = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
            }

            // QR KOD ÇÖZ
            else if (action == "decode" && qrFile?.Length > 0)
            {
                try
                {
                    using var stream = qrFile.OpenReadStream();
                    using Image<Rgba32> image = Image.Load<Rgba32>(stream);

                    var reader = new ZXingImg.BarcodeReader<Rgba32>
                    {
                        Options = new ZXing.Common.DecodingOptions
                        {
                            TryInverted = true
                        }
                    };

                    var result = reader.Decode(image);

                    ViewBag.DecodedText = result != null ? result.Text : "QR kod okunamadı.";
                }
                catch (Exception ex)
                {
                    ViewBag.Error = $"Hata: {ex.GetType().Name} - {ex.Message}";
                }
            }

            return View();
        }
    }
}

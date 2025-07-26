# 🍽️ SignalR Destekli Restoran Rezervasyon ve Sipariş Sistemi

**ASP.NET Core 8.0 Web API** ve **MVC** mimarisi kullanılarak inşa edilen sistemde, gerçek zamanlı iletişim için **SignalR**, veri yönetimi için **Entity Framework Code First**, mimari yapı olarak ise **N-Tier Architecture (Katmanlı Mimari)** ve **Repository Pattern** kullanılmıştır.

---

## 🔍 Projeye Genel Bakış

### 🖱️ Admin Paneli

- CRUD işlemlerinin yapılabildiği gelişmiş bir yönetim paneli.
- Rezervasyon onaylama/iptal etme.
- Gerçek zamanlı bildirimler, istatistikler ve mesajlaşma (SignalR destekli).
- Hakkımda, Ayarlar, Kategoriler gibi bölümlerin dinamik yönetimi.
- Mail gönderme işlemleri.

### 👤 Kullanıcı Arayüzü

- Duyarlı ve şık bir tasarım.
- Yemek siparişi oluşturma ve özetini görüntüleme.
- Admin ile birebir mesajlaşma (SignalR).
- Rezervasyon oluşturma ve özel mesaj gönderme.
- Hızlı, etkileşimli kullanıcı deneyimi için Ajax kullanımı.

---

## 🎯 Projenin Amacı

- Kullanıcılar web üzerinden yemek siparişi verebilir, sipariş özetini görebilir.
- Rezervasyon oluşturabilir, admin ile anlık mesajlaşabilir.
- Admin tarafı, rezervasyonlar, istatistikler ve bildirimleri **real-time** takip edebilir.
- Gelişmiş bir admin paneli ile içerik ve kullanıcı yönetimi yapılabilir.

---

## 🧰 Kullanılan Teknolojiler

| Teknoloji / Kütüphane       | Açıklama                                                                 |
|----------------------------|--------------------------------------------------------------------------|
| ✅ ASP.NET Core 8.0 MVC & API | Backend geliştirme                                                         |
| ✅ Repository Pattern        | Veri erişim yönetimi                                                     |
| ✅ N-Tier Architecture       | Katmanlı mimari (Entity, Business, DataAccess, API, MVC UI)              |                          
| ✅ Entity Framework Core    | Code-First veritabanı yönetimi                                           |
| ✅ AutoMapper               | Nesne eşleme işlemleri                                                   |
| ✅ Identity                 | Kimlik doğrulama ve yetkilendirme                                       |
| ✅ SignalR                  | Gerçek zamanlı bildirim ve mesajlaşma                                    |
| ✅ MSSQL                    | Veritabanı yönetimi                                                      |
| ✅ HTML, CSS, Bootstrap     | Responsive frontend tasarımı                                             |
| ✅ JavaScript               | Dinamik kullanıcı etkileşimi                                             |
| ✅ LINQ                    | Veri sorgulama                                                           |
| ✅ MailKit                  | E-posta gönderimi işlemleri                                              |

---

## ⚙️ Öne Çıkan Özellikler

- 🔴 **Real-Time Mesajlaşma (SignalR)**
- 📊 **Gerçek Zamanlı İstatistik Takibi**
- 🔔 **Gerçek Zamanlı Bildirim Sistemi**
- 🛒 **Sepet ve Sipariş Yönetimi**
- 📝 **Rezervasyon İşlemleri**
- 📩 **Ajax Tabanlı Mesaj ve Sipariş Gönderimi**
- 📬 **Mail Gönderme Modülü**

---
### 🗃️ Veritabanı Yapısı  
Entity Framework Code First ile oluşturulan veritabanı şeması.  
![veritabani](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/site/veritabani.png)


## 🌐 Kullanıcı Arayüzü (Site) - Ekran Görüntüleri

### 🖼️ Ana Sayfa  
![site1](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/site/site1.png)

### 🖼️ Menü Tanıtımı  
![site2](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/site/site2.png)

### 🖼️ Tanıtım Alanı  
![site3](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/site/site3.png)

### 🖼️ Rezervasyon Formu  
![site4](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/site/site4.png)

### 🖼️ Sipariş Listesi  
![site5](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/site/site5.png)

### 🖼️ Sipariş Ödeme Ekranı  
![site6](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/site/site6.png)

## 🛒 Sipariş Süreci ve Sistemsel Özellikler

### 🖼️ Masa Seçimi Ekranı  
Gerçek zamanlı dolu/boş masa durumu kontrolü.  
![masasecimi](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/site/masasecimi.png)

### 🖼️ Sepet Listesi  
Kullanıcının seçtiği ürünleri listeleme ve toplam tutar gösterimi.  
![sepet](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/site/sepet.png)

### 🖼️ Ürün Ekleme Bildirimi  
Kullanıcıya başarılı ürün ekleme bildirimi ekranı.  
![urunekleme](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/site/urunekleme.png)




## 📸 Admin Paneli - Ekran Görüntüleri

Aşağıda admin paneline ait ekran görüntülerine yer verilmiştir. Her sayfa, yöneticilere içerik ve işlem kontrolü sağlamaktadır.

### 🖼️ Hakkımda Sayfası  
![about](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/admin/about.png)

### 🖼️ Anlık Durum Paneli  
![anlikdurum](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/admin/anlikdurum.png)

### 🖼️ Bildirim Sayfası  
![bildirim](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/admin/bildirim.png)

### 🖼️ İletişim Mesajları  
![iletisim](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/admin/iletisim.png)

### 🖼️ İndirim Kuponları  
![indirim](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/admin/indirim.png)

### 🖼️ İstatistik Paneli  
![istatistik](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/admin/istatistik.png)

### 🖼️ Kategori Yönetimi  
![kategori](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/admin/kategori.png)

### 🖼️ Mail Gönderme  
![mail](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/admin/mail.png)

### 🖼️ Masa Durumları  
![masadurumlari](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/admin/masadurumlari.png)

### 🖼️ Masa Listesi  
![masalist](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/admin/masalist.png)

### 🖼️ Öne Çıkanlar  
![onecikanlar](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/admin/onecikanlar.png)

### 🖼️ QR Kod Oluşturucu  
![qrcode](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/admin/qrcode.png)

### 🖼️ Referanslar  
![referans](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/admin/referans.png)

### 🖼️ Rezervasyonlar  
![rezervasyon](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/admin/rezervasyon.png)

### 🖼️ Ayarlar  
![setting](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/admin/setting.png)

### 🖼️ Ürün Yönetimi  
![ürün](https://github.com/AOghuz/SignalRProject/blob/master/SignalRWebUI/wwwroot/signalrimages/admin/ürün.png)



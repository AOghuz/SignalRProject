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

## 📦 Proje Yapısı


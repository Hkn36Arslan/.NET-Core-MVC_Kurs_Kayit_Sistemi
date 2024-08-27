# BTK Akademi Kayıt ve Yönetim Sistemi

Bu proje, BTK Akademi bünyesindeki üç ayrı eğitime katılım sağlamak isteyen kullanıcıların başvuru yapabilmelerini ve bu başvuruların yönetici (admin) tarafından görüntülenmesini sağlayan bir .NET Core MVC uygulamasıdır.

## Özellikler

- **Eğitim Başvurusu:** Kullanıcılar, BTK Akademi tarafından sunulan üç farklı eğitime başvuruda bulunabilirler.
- **Başvuru Yönetimi:** Admin kullanıcıları, yapılan başvuruları uygulama üzerinden görüntüleyebilir ve yönetebilirler.
- **Bootstrap Desteği:** Kullanıcı arayüzü, Bootstrap CSS framework kullanılarak modern ve kullanıcı dostu bir şekilde tasarlanmıştır.

## Kurulum

1. **Depoyu Klonlayın:**
    ```bash
    git clone https://github.com/Hkn36Arslan/BtkAkademiProject.git
    cd BtkAkademiProject 
    ```
2. **Gereksinimleri Yükleyin:**
   Projenin çalışabilmesi için .NET Core SDK'sını indirip kurmanız gerekmektedir. [Buradan](https://dotnet.microsoft.com/download) indirebilirsiniz.

3. **Proje Bağımlılıklarını Yükleyin:**
    ```bash
    dotnet restore
    ```

4. **Kayıt verilerinin hafızada tutulması.**
   Uygulama bir veritabanı kullanmamaktadır. Static bir şekilde Repository modeli altında bir liste oluşturularak veriler burada saklanmaktadır.

5. **Uygulamayı Çalıştırın:**
    ```bash
    dotnet run
    ```

6. **Uygulamayı Tarayıcıda Açın:**
   Uygulama varsayılan olarak `https://localhost:5001` adresinde çalışacaktır.

## Kullanım
### 1. Başvuru Yapma
- Kullanıcılar, ana sayfada bulunan "Apply" butonuna tıklayarak eğitim başvuru formunu doldurabilirler.
- Kullanıcılar, ad-soyad, e-posta adresi,ya ve katılmak istedikleri eğitimi seçerek başvurularını tamamlayabilirler.

### 2. Başvuruları Görüntüleme
- Admin kullanıcıları, `Applications` sayfasına erişerek tüm başvuruları listeleyebilir.
- Listeleme sayfasında, her başvurunun detayları (Email, Full Name, Apply At, Course) görüntülenebilir.

## Proje Yapısı
- **Controllers:** Kullanıcı isteklerini yönlendiren ve işleyen controller sınıfları.
- **Models:** Veritabanı ve iş mantığı için kullanılan veri modelleri.
- **Views:** Razor View Engine kullanılarak dinamik olarak oluşturulan HTML sayfaları.
- **wwwroot:** Statik dosyalar (CSS, JS, img) için kullanılan klasör.

## Katkıda Bulunma
Katkıda bulunmak isterseniz lütfen bir `fork` yapın ve bir `pull request` gönderin.

## Lisans
Bu proje MIT Lisansı altında lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasını inceleyin.

## İletişim
Herhangi bir sorunuz veya geri bildiriminiz varsa, lütfen benimle iletişime geçin: [hakanarslan3625@gmail.com]

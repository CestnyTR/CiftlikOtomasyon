# 🐄 Çiftlik Otomasyonu

> Farm management desktop app — C# WinForms, Entity Framework 6 and SQL Server (university final project).

Bir hayvancılık çiftliğinin günlük işlerini takip etmek için geliştirilmiş masaüstü uygulaması.
Hayvanlar, süt üretimi ve stok tek bir yerden yönetilir. Üniversite bitirme projem olarak geliştirdim.

## Özellikler

- **Giriş ekranı ve kullanıcı rolleri:** Kullanıcı ve rol yönetimi.
- **Hayvan kayıtları:** Hayvanları ve cinslerini tanımlama.
- **Süt üretimi:** Günlük süt üretimini kaydetme ve takip etme.
- **Stok yönetimi:** Stok türleri, stok kartları ve stok giriş/çıkış hareketleri.
- **Raporlar:** Stok ve süt stoğu raporları (RDLC).

## Teknolojiler

C# · .NET Framework 4.7.2 · Windows Forms · Entity Framework 6 (Database First) · SQL Server · RDLC raporları

## Kurulum

1. Depoyu klonla ve `CiftlikOtomasyon.sln` dosyasını **Visual Studio** ile aç.
2. NuGet paketlerini geri yükle (Visual Studio açılışta otomatik yapar).
3. SQL Server'da `Ciftlik` adında bir veritabanı oluştur. Tabloları `Model1.edmx` modelinden üretebilirsin:
   modeli aç → sağ tık → **Generate Database from Model**.
4. `App.config` içindeki bağlantı dizesinde `Data Source` değerini kendi SQL Server adınla değiştir.
5. Projeyi çalıştır (F5).

> Veritabanı yedeği depoda yok; tablolar EF modelinden oluşturulur.

## Proje yapısı

| Dosyalar | Açıklama |
|---|---|
| `frm*.cs` | Ekranlar: giriş, ana ekran, hayvan, cins, süt takip/üretim, stok, stok hareket, kullanıcılar, roller |
| `Model1.edmx` | Entity Framework veri modeli |
| `v*.cs` | Raporlama ve listeleme için veritabanı görünümleri (view) |
| `rpr*.rdlc` | Stok ve süt stoğu raporları |

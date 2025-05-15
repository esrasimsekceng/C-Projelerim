Bu proje, C# ve Windows Forms kullanılarak geliştirilmiş basit bir kitap takip uygulamasıdır. SQL Server veritabanı ile kitap ekleme, silme, güncelleme ve listeleme işlemleri yapılabilir.

# 🔧 Özellikler
Kitapları listeleme (DataGridView)

Yeni kitap ekleme

Kitap güncelleme

Kitap silme

Kitap türü seçimi (ComboBox ile)

## 🗃️ Veritabanı
Veritabanı adı: Kitap

Tablo: TblKitaplar

Alan	Tür
KitapID	int (PK)
KitapAd	nvarchar
Yazar	nvarchar
Sayfa	int
Fiyat	decimal
Yayınevi	nvarchar
Tur	int

Tür ID'leri:

9: Hikaye

10: Roman

11: Şiir

12: Tiyatro

### ⚙️ Bağlantı
c#
string connectionString = "Server=.;Database=Kitap;User Id=sa;Password=123;";
Gerekirse kendi sunucu ve şifre bilgilerinize göre düzenleyin.

#### 💻 Geliştirme Ortamı
 Microsoft Visual Studio

.NET Framework

MSQL Server
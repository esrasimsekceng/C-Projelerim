Bu proje, C# Windows Forms kullanılarak oluşturulmuş bir grafik uygulamasıdır. Kullanıcıdan alınan sayısal verilerle çeşitli şekiller (çizgi, üçgen, kare) ve bu verilerle oluşturulan pasta (pie) grafiği arayüzde çizilmektedir.

# Özellikler
Çizgi çizimi: Form üzerine yatay bir çizgi çizilir.

Üçgen çizimi: Belirlenen koordinatlara göre bir üçgen çizilir.

Kare çizimi: Formun altında bir kırmızı kare çizilir.

Pasta Grafiği: Kullanıcının girdiği 3 sayıya göre orantısal bir pie chart oluşturulur ve renklendirilir.

Klasör seçme: FolderBrowserDialog kullanılarak bir klasör yolu seçilebilir.

## Kullanılan Bileşenler
Graphics ve Pen sınıfları ile çizim yapılır.

SolidBrush sınıfı ile alanlar renklendirilir.

TextBox bileşenleri ile kullanıcıdan sayısal veri alınır.

MessageBox ile kullanıcıya hata mesajı verilir.

### Arayüz
Form üzerinde bulunan kontroller:

3 adet TextBox: Pasta grafiği için veri girişleri.

1 adet Label: Seçilen klasör yolunu gösterir.

2 adet Button:

button1: Grafik çizimini başlatır.

button2: Klasör seçme penceresini açar.

#### Kurulum ve Çalıştırma
Visual Studio'da yeni bir Windows Forms projesi oluşturun.

Bu kodu Form1.cs dosyasına yapıştırın.

Form1 tasarım kısmına aşağıdaki kontrolleri ekleyin:

3 adet TextBox

2 adet Button (button1, button2)

1 adet Label

1 adet FolderBrowserDialog (folderBrowserDialog1)

Projeyi başlatın ve button1 ile çizimleri gerçekleştirin.

##### Notlar
Kullanıcının girdiği sayıların toplamı sıfır olmamalıdır. Aksi takdirde hata mesajı verilir.

Grafik çizimi, formun üzerine doğrudan yapılır; bu nedenle form yeniden boyutlandırılırsa çizimler kaybolabilir.
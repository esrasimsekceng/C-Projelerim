# 🧵 Çok İş Parçacıklı (Multithreading) WinForms Uygulaması

Bu proje, C# dilinde Windows Forms kullanılarak geliştirilmiş **çok iş parçacıklı (multithreaded)** bir uygulamadır. Projede, farklı senkronizasyon yöntemleri kullanılarak eş zamanlı çalışan 3 iş parçacığının GUI üzerindeki `ProgressBar` ve `ListBox` kontrollerine erişimi kontrol edilmektedir.

## 🎯 Proje Amacı

Bu uygulama, aşağıdaki senkronizasyon mekanizmalarını karşılaştırmalı olarak göstermeyi amaçlar:

- Standart iş parçacığı kullanımı (Thread)
- `Interlocked`
- `lock` 
- `Monitor`
- `Mutex`
- `Semaphore`

## 🧩 Özellikler

- 3 adet iş parçacığı (`Thread`) aynı anda farklı progress bar'ları artırır.
- Senkronizasyon teknikleri sayesinde GUI bileşenlerine güvenli erişim sağlanır.
- Her senkronizasyon tekniği için ayrı bir buton üzerinden örnek çalıştırılabilir.
- `ListBox` üzerinden her thread’in çalıştığı anlar görselleştirilir.
- `Sıfırla` butonu ile uygulama varsayılan hale döner.

## 🧪 Kullanılan Senkronizasyon Teknikleri

| Teknik       | Açıklama |
|--------------|----------|
| `Interlocked` | Atomik artırım sağlar (veri yarışını önler). |
| `lock`        | Belirli bir nesne üzerinden bölgesel kilitleme yapar. |
| `Monitor`     | `lock` ile benzer, ancak `Enter/Exit/Pulse` gibi daha gelişmiş kontrol sunar. |
| `Mutex`       | Sistem genelinde kilit sağlayan senkronizasyon nesnesidir. |
| `Semaphore`   | Aynı anda sınırlı sayıda iş parçacığının çalışmasına izin verir. |

## 💡 Kullanım

1. Visual Studio'da projeyi açın.
2. Uygulamayı çalıştırın (`F5`).
3. Aşağıdaki butonlar ile farklı senkronizasyon tekniklerini test edebilirsiniz:

| Buton         | İşlev |
|---------------|-------|
| `Başlat` (`button1`) | Standart thread çalıştırma |
| `Interlocked` (`button2`) | `Interlocked` ile senkronize çalışma |
| `lock` (`button3`) | `lock` anahtar sözcüğü ile |
| `Monitor` (`button4`) | `Monitor.Enter/Exit` ile |
| `Mutex` (`button6`) | `Mutex` ile thread senkronizasyonu |
| `Semaphore` (`button7`) | `Semaphore` ile sınırlandırılmış erişim |
| `Sıfırla` (`button5`) | Thread'leri durdurur ve GUI'yi sıfırlar |

## 🛑 Notlar

- GUI elemanlarına birden fazla iş parçacığı eriştiği için `Control.CheckForIllegalCrossThreadCalls = false;` ayarlanmıştır. Ancak bu yaklaşım prodüksiyon ortamında önerilmez.
- Her senkronizasyon yöntemi kendi avantaj ve kullanım senaryolarına sahiptir.
- `Semaphore` varsayılan olarak 0 izin ile başlatılmış olup, çalıştırma sırasında `Release(2)` çağrılarak iki thread’e izin verilir.


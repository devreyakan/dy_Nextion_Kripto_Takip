
# Nextion HMI Kripto Takip Uygulaması
Nextion HMI Ekranları seri haberleşme yoluyla doğrudan bilgisayara bağlayabileceğiniz bu projede harici bir mikro denetleyici kullanmadan doğrudan bilgisayar üzerinden kullanabilmeniz amaçlanmıştır. Senaryo olarak, blockchain.info üzerinden güncel Bitcoin fiyatı çekilmiştir.

Detaylı bilgiler ve içerik: https://devreyakan.com/nextion-hmi-kripto-takip-uygulamasi-c

## Uyarı
Bu programı kullanmadan önce mutlaka "Sermaye Piyasası Kurulunun Seri:V, No:55 Yatırım Danışmanlığı Faaliyetine ve Bu Faaliyette Bulunacak Kurumlara İlişkin Esaslar Hakkında Tebliğ’i Uyarınca Yayımlanan Uyarı Notu"nu okumanız gerekmektedir.

Kullanıcının verecekleri yatırım kararları ile bu proje ve sitede bulunan veriler, görüş ve bilgi arasında bir bağlantı kurulamayacağı gibi, söz konusu yorum/görüş/bilgilere daynılarak alınacak kararların neticesinde oluşabilecek yanlışlık veya zararlardan devreyakan.com ve repo sahibi sorumlu tutulamaz.

Burada yer alan yatırım bilgi, yorum ve tavsiyeleri yatırım danışmanlığı kapsamında değildir. Yatırım danışmanlığı hizmeti, aracı kurumlar, portföy yönetim şirketleri, mevduat kabul etmeyen bankalar ile müşteri arasında imzalanacak yatırım danışmanlığı sözleşmesi çerçevesinde sunulmaktadır. Burada yer alan yorum ve tavsiyeler, yorum ve tavsiyede bulunanların kişisel görüşlerine dayanmaktadır. Bu görüşler, mali durumunuz ile risk ve getiri tercihlerinize uygun olmayabilir. Bu nedenle, sadece burada yer alan bilgilere dayanılarak yatırım kararı verilmesi, beklentilerinize uygun sonuçlar doğurmayabilir.

Piyasa verileri blockchain.info tarafından sağlanmaktadır ve 15 dakika gecikmeli olarak yayınlanır. Kullanacağınız API'ye göre bu veriler değişmektedir.

https://devreyakan.com/yasal-uyari/


## Yükleme ve Kurulum

Windows form .NET Framework 4.8, C# ile hazırlanmıştır.

Git ile klonlamak için
```bash 
https://github.com/devreyakan/dy_Nextion_Kripto_Takip.git
```
 GitHub CLI ile klonlamak için
  ```bash 
gh repo clone devreyakan/dy_Nextion_Kripto_Takip
```  
  
## Optimizasyon ve İyileştirmeler

.NET Framework 4.8 ve üzeri kurulu Windows tabanlı cihazlarda çalışmaktadır. Zaman damgası içi NIST, Google, bilgisayar saatini kullanabilirsiniz. Bu kısımlar yorum olarak bırakılmıştır, kod üzerinde çalışır şekilde bilgisayar saati kullanılmaktadır. Google ya da NIST üzerinden zaman verisini çekerken try-catch ve sadece 4 saniyede bir veri çekmeniz daha iyi olacaktır. Örnek olması açısından verileri json formatı olarak çekerek işledik, burada istediğiniz API'yi kullanabilirsiniz, tamamen size kalmış durumda.
    
## Cihaz Bilgileri

HMI dosyası 2.8" ekran boyutuna göre hazırlanmıştır fakat istediğiniz ekran boyutuna göre revize edebilirsiniz, windows form kısmında gönderdiğiniz verilerde obje isimleri ne ise HMI tasarımında aynı olmasına özen göstermeniz gerekmekte ve verileri HEX olarak göndermelisiniz.



## Ekran Görüntüleri

<p align="center">
  <img src="https://github.com/devreyakan/dy_Nextion_Kripto_Takip/blob/master/Gorseller/Screenshot_1.png" width="350" title="Simülasyon">
</p>

<p align="center">
  <img src="https://github.com/devreyakan/dy_Nextion_Kripto_Takip/blob/master/Gorseller/Screenshot_1.png" width="350" title="Simülasyon">
</p>


<p align="center">
  <img src="https://github.com/devreyakan/dy_Nextion_Kripto_Takip/blob/master/Gorseller/Screenshot_1.png" width="350" title="Simülasyon">
</p>


<p align="center">
  <img src="https://github.com/devreyakan/dy_Nextion_Kripto_Takip/blob/master/Gorseller/Screenshot_1.png" width="350" title="Simülasyon">
</p>


<p align="center">
  <img src="https://github.com/devreyakan/dy_Nextion_Kripto_Takip/blob/master/Gorseller/Screenshot_1.png" width="350" title="Simülasyon">
</p>


<p align="center">
  <img src="https://github.com/devreyakan/dy_Nextion_Kripto_Takip/blob/master/Gorseller/Screenshot_1.png" width="350" title="Simülasyon">
</p>


![Form](https://github.com/devreyakan/dy_Nextion_Kripto_Takip/blob/master/Gorseller/Screenshot_2.png)
![Nextion Editor GUI](https://github.com/devreyakan/dy_Nextion_Kripto_Takip/blob/master/Gorseller/Screenshot_3.png)
![Test Görüntüsü](https://github.com/devreyakan/dy_Nextion_Kripto_Takip/blob/master/Gorseller/rbitcoin.JPG)
![Çevrimdışı Görüntüsü](https://github.com/devreyakan/dy_Nextion_Kripto_Takip/blob/master/Gorseller/rcevrimdisi.JPG)

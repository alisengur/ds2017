# ds2017
Veri Yapıları Dersi işlenen kodlar
## Kodları Çalıştırma
Kodları iki farklı şekilde çalıştırabilirsiniz.
### Tüm dosyaları sıkıştırılmış olarak indirme
[Bu bağlantı](https://github.com/sevketcakir/ds2017/archive/master.zip)ya tıklayarak tüm güncel kodları bilgisayarınıza sıkıştırılmış dosya olarak indirebilirsiniz.
### Git kod versiyonlama yazılımını kullanarak güncel kodları siteden alma
İlk defa kodları alırken komut satırında aşağıdaki kod çalıştırılabilir. Bu işlem güncel kodları ds2017 klasörü içine kopyalar/indirir.
```sh
git clone https://github.com/sevketcakir/ds2017.git
```
Yapılan değişiklikleri siteden almak için:
- Yerelde kodlarda değişiklik yapılmamışsa ds2017 klasöründe aşağıdaki kod çalıştırılabilir.
```sh
git pull origin master
```
- Yerelde değişiklik olduğunu anlamak için aşağıdaki komut sonucunda kırmızı renkli değerlere bakılır. Varsa yerelde değişiklik yapılmıştır.
```sh
git status
```
- Yerelde değişiklik olması durumunda aşağıdaki işlemler yapılabiir
  * Tüm kodları yeniden klonlama
  * Yerel değişiklikleri geri alıp siteden verileri çekme(Uyarı: yapmış olduğunuz tüm değişiklerin kaybolmasına neden olacaktır!!!)
```sh
git reset --hard
git pull origin master
```
*  * Yerel değişiklikleri onaylayıp(commit) güncel verileri çekme(Bu yöntemde github üzerindeki kodlar ile  yereldeki kodlar üzerinde çakışma(conflict) olması durumunda yerel ve uzak kodları birleştirme(merge) gerekecektir. Daha detaylı bilgi için bkz: [1](https://git-scm.com/book/tr/v1), [2](http://rogerdudler.github.io/git-guide/index.tr.html) ve [3](https://www.google.com.tr/search?q=git+kullan%C4%B1m%C4%B1)): 
```sh
git add -A
git commit -m "Commit mesajı"
git pull origin master
```

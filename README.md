# Dördüncü Ödev ☂️

## İsterler 👒
* Hangfire yada Quartz kullanarak SQL Serverda oluşturduğunuz bir tabloda işlem yapacak job'lar geliştiriniz.Dataya erişim olarak UnitOfWork veya Dapper kullanabilirsiniz.
SQL Serverda kendi random tablonuzu herhangi bir modelde oluşturabilirsiniz. (İçerisibde Status isminde bir alan olsun.) Datalar statik yada dinamik generate edilebilir .

* 15 dakikada 1 kez çalışacak bir job ekleyerek bu tabloya insert atınız.
Günde bir kez 18.00 da çalışarak o güne kadar eklenmiş olan kayıtların Status alanını farklı bir değer olarak güncelleyen bir job ekleyiniz.

### Controller'daki Get ve Post metotları tetiklendiğinde Hangfire Dashboard görüntüsü aşağıdadır ⬇️
![alt text](https://github.com/160-Sodexo-NET-Bootcamp/dorduncuhaftaodevi-ipekserttas99/blob/main/HangfireAssignment/img/1.png)

### Create için oluşturulan Job'un dashboard görüntüsü ⬇️
![alt text](https://github.com/160-Sodexo-NET-Bootcamp/dorduncuhaftaodevi-ipekserttas99/blob/main/HangfireAssignment/img/create.JPG)

### Update için oluşturulan Job'un dashboard görüntüsü ⬇️
![alt text](https://github.com/160-Sodexo-NET-Bootcamp/dorduncuhaftaodevi-ipekserttas99/blob/main/HangfireAssignment/img/update.JPG)

### 15 dakikada bir sqlserver'daki tabloya status'leri Passive olan kayıtlar atılıyor. Saat 18:00 olduğunda kayıtlardaki Status Active olarak güncelleniyor. 18:00'den sonra atılan kayıtların Status'u aşağıdaki gibi Passive olarak ekleniyor. 
![alt text](https://github.com/160-Sodexo-NET-Bootcamp/dorduncuhaftaodevi-ipekserttas99/blob/main/HangfireAssignment/img/2.JPG)

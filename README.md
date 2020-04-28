# 4_Veri_Toplama-



*Sensör kullanılarak yapılan uygulama veya deneysel çalışmalarda alınan ölçümlerin mobile aktarılması için veri işleme kartlarına ihtiyaç duyulmaktadır. Bu tür çalışmalarda kullanım kolaylığı açısından en çok tercih edilen platformlardan birisi de Arduino'dur. Açık kaynaklı bir geliştirme platformu olan Arduino’nun dijital ve analog girişleri sayesinde veriler okunup anlık olarak işlenebilmektedir. Akıllı ev çalışmasında, mobil ortamda App Inventor kullanarak geliştirilen uygulama sayesinde Arduino'ya bağlanan farklı sensörler içerisinden istenilen sensörler seçilebilmektedir. Seçilen bu sensörleri kullanmak için gerekli Arduino kodu oluşturulabilmektedir. Arduino üzerindeki sensörlerden gelen veriler belirli zaman aralığında veya anlık olarak kaydedilebilmektedir. Kaydedilen verilerin, istenilen periyotlarda ve özelliklerde elde edilebilmekte ve kullanılabilmektedir.*<br/><br/><br/>

*Sensörler, fiziksel veya kimyasal büyüklükleri elektriksel büyüklüklere çevirerek kullanılabilir formata dönüştürmektedirler. Sensörler kablosuz iletişim, sinyal algılama, alınan sinyali işleme ve yayma gibi yeteneklere sahiptir. Sensörler kullanılarak yapılan uygulama veya deneysel çalışmalarda alınan ölçümlerin bilgisayara aktarılması için veri toplama kartlarına ihtiyaç duyulmaktadır.*<br/>


#### *Verilerin Toplanması ve Kontrol Edilmesi*

##### *Hareket Sensörü*
*Projemizde hareket sensörü kullanarak herhangi bir harekette sensör durumu algılayacak. Sistemi uyararak alarm devreye girecek ve güvenlik sistemi çalışacak. Sistem oldukça  kullanışlıdır. <br/>
Genel olarak akşam-gece saatlerinde hırsızların çok olduğu zamanda sistem tarafından veriler alınmakta olup daha çok güvenliği ön planda tutmak amaçlanmaktadır..*

##### *Işıklar* 
*Evdeki ışıklar, kullanıcı isteği ile etkinleşir. Kullanıcı evden uzakta olsa bile ışıklara müdahale edip kapatıp açabilir. <br/>
Veriler, gündüz güneşli saatlerde ışıkların kapalı, akşam saatlerinde ışıkların açık olduğu şeklinde alınmaktadır.*

##### *Alarm*
*Zorlama ile eve giriş sağlandığı anda etkinleşir. Hareket sensörüyle birlikte çalışır.<br/>
Eğer sistem bir hareket algılarsa buzzer devreye girer ve alarm çalar.*

##### *Mesafe Sensörü*
 *Park işlemlerini kolaylaştırır. Burada minimum mesafe 10cm olarak ayarladığı zaman arabanın kolay bir şekilde park edilmesini sağlamaktadır.<br/>
 Veriler genellikle, akşam iş dönüşünde alınmaktadır. Çünkü genel olarak akşam arabanın park edilmesi üzerine veriler akşam saatlerinde çok alınır.*
 
##### *Sulama*
 *Toprağın kuruduğunu sistem anladığı zaman su vermektedir. <br/>
 <br/>
 
*Veriler toprağın kuruluğuna bakıp almaktadır. Eğer topraktaki su miktarı az ise sistem tarafından toprağa su verilmektedir.<br/>
Genel olarak da tatil modu durumunda iken evdeki çiçekler sulanmaktadır.* 

##### *Isı-Nem Sensörü*
*Bu sensör sayesinde çevrenin ısı-nemi algılanır ve ona göre sisteme veri gönderir ve veri tabanında güncellenmiş olur.*

##### *Giriş*
*Kullanıcı sisteme kullanıcı adı ve şifresiyle birlikte giriş yapmaktadır.<br/> 
Sistem tarafından kullanıcı bilgileri verileri alınır ve kullanıcı arayüzünde görünür.*

4_Veri_Toplama_
Sensör kullanılarak yapılan uygulama veya deneysel çalışmalarda alınan ölçümlerin mobile aktarılması için veri işleme kartlarına ihtiyaç duyulmaktadır. 
Bu tür çalışmalarda kullanım kolaylığı açısından en çok tercih edilen platformlardan birisi de Arduino'dur. 
Açık kaynaklı bir geliştirme platformu olan Arduino’nun dijital ve analog girişleri sayesinde veriler okunup anlık olarak işlenebilmektedir. 
Akıllı ev çalışmasında, mobil ortamda App Inventor kullanarak geliştirilen uygulama sayesinde Arduino'ya bağlanan farklı sensörler içerisinden istenilen sensörler seçilebilmektedir. 
Seçilen bu sensörleri kullanmak için gerekli Arduino kodu oluşturulabilmektedir. 
Arduino üzerindeki sensörlerden gelen veriler belirli zaman aralığında veya anlık olarak kaydedilebilmektedir. 
Kaydedilen veriler, istenilen periyotlarda ve özelliklerde elde edilebilmekte ve kullanılabilmektedir.

Sensörler, fiziksel veya kimyasal büyüklükleri elektriksel büyüklüklere çevirerek kullanılabilir formata dönüştürmektedirler. 
Sensörler kablosuz iletişim, sinyal algılama, alınan sinyali işleme ve yayma gibi yeteneklere sahiptir. 
Sensörler kullanılarak yapılan uygulama veya deneysel çalışmalarda alınan ölçümlerin bilgisayara aktarılması için veri toplama kartlarına ihtiyaç duyulmaktadır.

Verilerin Toplanması ve Kontrol Edilmesi

Hareket Sensörü
Projemizde hareket sensörü kullanarak herhangi bir harekette sensör durumu algılayacak. Sensör sistemi uyararak alarm devreye girecektir. Bu sensör oldukça kullanışlıdır. Artık akıllı evler bu sensör sayesinde daha güvenlidir. 
Genel olarak akşam-gece saatlerinde hırsızların çok olduğu zamanda sistem tarafından veriler alınmakta olup daha çok güvenliği ön planda tutmak amaçlanmaktadır.

Işıklar
Evdeki ışıklar, kullanıcı isteği ile etkinleşir. Kullanıcı evden uzakta olsa bile ışıklara müdahale edip kapatıp açabilir. 
Veriler, gündüz güneşli saatlerde ışıkların kapalı, akşam saatlerinde ışıkların açık olduğu şeklinde alınmaktadır.
Aynı zamanda evden uzaktayken veya tatildeyken evin ışıklarını kontrol edip, hırsız girmemesi için akşam saatlerinde evde biri varmış hissi uyandırmak için kullanılır. Sabahleyin tekrardan ışıklar kapatılır.

Alarm
Zorlama ile eve giriş sağlandığı anda etkinleşir. Hareket sensörüyle birlikte çalışır.
Genel olarak hırsızların aktif olduğu zamanlarda çalışır.
Eğer sistem bir hareket algılarsa buzzer devreye girer ve alarm çalar.

Mesafe Sensörü
Park işlemlerini kolaylaştırır. Burada minimum mesafe 10cm olarak ayarladığı zaman arabanın kolay bir şekilde park edilmesini sağlamaktadır.
Veriler genellikle, akşam iş dönüşünde alınmaktadır. Çünkü genel olarak akşam arabanın park edilmesi üzerine veriler akşam saatlerinde çok alınır.
 
Sulama
Toprağın kuruduğunu sistem anladığı zaman su vermektedir. 
Veriler toprağın kuruluğuna bakıp alınmaktadır. Eğer topraktaki su miktarı az ise sistem tarafından toprağa su verilmektedir.
Genel olarak da tatil modu durumunda iken evdeki çiçekler sulanmaktadır.

Perde Sistemi 
Bu sistem akıllı evde oldukça işe yarayan bir sistemdir. Kullanıcı tek bir tuşla mobil uygulamadan basarak sabahları perdeyi açar ve akşamları tekrar kapatır.
Genel olarak perde sisteminden alınan veriler şu yöndedir; sabah saatlerinde perde açık, akşam saatlerinde perde kapalı durumda olduğu bilgisi alınmaktadır.

Isı-Nem Sensörü
Bu sensör sayesinde çevrenin ısı-nemi algılanır ve ona göre sisteme veri gönderir ve veri tabanında güncellenmiş olur.



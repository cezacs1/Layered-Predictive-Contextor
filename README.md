# LPC (Layered Predictive Contextor)

**Layered Predictive Contextor**, gerçek bir CS2 oyuncusunun oyun içi davranışlarını öğrenmek için geliştirilmiş, çok katmanlı ve karar tabanlı bir yapay zeka modelidir.  
Model, **MoE (Mixture of Experts)** yaklaşımıyla çalışır; yani farklı alanlarda ve olaylarda uzmanlaşmış modelleri birlikte kullanarak birden çok durumu analiz eder ve karar verir.

### Örnek Expert Modeller

**ExExpertModelPaths**  
Oyuncunun hareketlerini, pusmalarını, rotate ve retake kararlarını analiz eder.  
Bir yerden başka bir yere geçişleri hem `placeName` hem de `Vector3 HeadPosition` olarak kaydeder.  
Amacı, oyuncunun neden oraya gittiğini, orada neden beklediğini ve bu hareketin ne kadar mantıklı olduğu gibi sorulara yanıt aramaktır.

**ExExpertModelGrenades**  
Oyuncuların bomba kullanımını ve etkisini analiz eder.  
Neden o bombayı oraya attı, etkili oldu mu, hangi oyuncular bundan etkilendi, ne kadar sürdü, daha önce aynı şey yaşanmış mıydı gibi soruları değerlendirir.

**ExExpertModelEconomy**  
Oyuncuların ekonomik kararlarını anlamaya çalışır.  
Ne zaman silah alıyor, ne zaman eco yapıyor, oyuncuların para durumu neydi gibi kararların arkasındaki stratejileri analiz eder.

---

Bunlar gibi alanında uzaman birçok modeli birlikte çalışarak gerçekçi, bağlamsal ve öğrenen bir karar mekanizması oluşturur.  
Amaç sadece oyuncunun **ne yaptığını** değil, **neden yaptığını** da öğrenmek ve buna göre **akıllıca kararlar alabilen** bir yapay zeka olmasıdır.

Gerçek bir oyuncu bile bu kadar çok veriyi aynı anda değerlendiremez.  
İnsanlar genellikle sıralı şekilde düşünür ve kararlarını refleks, anlık değerlendirme ya da genel sezgiye göre verir.

---

## İlk Modelimiz: LPC-Atom

**LPC-Atom**, detaylı düşünme gerektirmeyen DeathMatch oyun moduna uyum sağlamak için geliştirilen, çok hızlı ve küçük bir modeldir.

### Temel Özellikleri
- Oyunu açıp maça girebilir, atıldıysa tekrar bağlanabilir.  
- Maç başladığında uygun bir silahı alır.  
- Maç esnasında en yakın oyuncuya doğru hareket ederek oynar, detaylı düşünmez ve stratejik analiz yapmaz.

---

## Not

**Bu sistemin amacı, CS2'de bir hile gibi oynamak değil; gerçek bir oyuncu gibi düşünen bir yapay zeka üretmektir.**

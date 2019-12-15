# Singleton Tasarım Deseni 
Singleton (Tek Nesne) tasarım deseni bir sınıfın tek bir örneğini oluşturmak için kullanılır. Amaç sınıftan sadece bir tane örnek oluşturup her yerde onu kullanmaktır. Buradaki önemli bir konu birden fazla işlem parçacığına (thread) sahip uygulamalarda bu deseni kullanırken güvenli bir şekilde oluşturmaktır. Yani birden fazla örnek oluşmaması için **kilitlenme (lock)** kullanılmalıdır. 

**Kilitleme (Lock):** Birden fazla işlem parçacığı (thread) üzerinde işlem yapıyorsanız belirli işlemler için aynı anda sadece bir tane işlem parçacığına (thread) izin vermek için kullanılan yapıdır.

## Çalışma Mantığı Nasıl?
Bir tane örneği oluşturulmak istenen sınıfın **new** sözcüğü ile çağrılamaması için yapıcı metodu (constructor) **private** (gizli) olarak oluşturulur. Sınıfın içinde dışarıya açılacak metot **static** olarak tanımlanır. Sınıfın içerisinde bir örnek oluşturulur ve dışarıya o açılır.

## Ne Zaman Kullanılır?
Projemizde sürekli yeni bir örneğini oluşmak istemediğimiz veri tabanı bağlantısı, Log, Cache gibi sınıfların oluşturulmasında kullanılabilir.

## İlişkili Olduğu Tasarım Desenleri Nelerdir? 
Bir çok tasarım deseni Singleton (Tek Nesne) tasarım deseni ile ilişkilidir. Benzer kullanımları görmek için Abstract Factory, Builder ve Prototype tasarım desenine bakabilirsiniz.

namespace Singleton_Desing_Pattern
{



    /*
     
     Uygulama içerisnde bir nesnein bir kere yaratılmasını garanti altına almak
    istediğimiz durumlarda bu patterni uyguluyoruz

    1-) Uygulama boyunca tek bir örneğe sahip olmasını istediğimiz sınıfın
      constructor'unı private hale getiriyoruz
    2-) sınıf içerisidne sınıf o sınıf türünden referans tutan bir değişken tanımlıyoruz
    3-) constructor artık dışarıdan erişme kapalı olduğu için contructor göreveri görecek bir static method yazıyoru

     
     */


    internal class Program
    {
        static void Main(string[] args)
        {


            //1.adım bir örnek oluşturuyoruz

            // Single instance1 = new Single(); => Görüldüğü gibi constructor'a erişim yok

            Single instance1 = Single.CreateObject();
            instance1.Data = 10;

            Console.WriteLine($"ilk oluşturalan nesnein datası {instance1.Data}");


            Single instance2 = Single.CreateObject();

            Console.WriteLine($"ikinci oluşturalan nesnein datası {instance2.Data}");
            //biz herhangi bir data vermedik ama nesne zaten oluştuğu için yeniden bir 
            //nesne yaratmayıp mecvut varol instance1'in bir referansını döndü
         

        }
    }
}
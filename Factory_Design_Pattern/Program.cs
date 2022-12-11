using Factory_Design_Pattern.Concreate_Factory;

namespace Factory_Design_Pattern
{
    internal class Program
    {


        /*
            
            Diğer adıyla Virtual Constructor diye bilinir
            Fabrika Tasarım Deseni kullanıcının alt sınıf 
            kullanımını ve bu alt sınıfları nasıl kullanacağını 
            bilmediği durumlarda kullanılır.
         
         */


        static void Main(string[] args)
        {

            //A ve B ürünlerinin yönetimsel süreçleri çok benzer
            //A ve B iki ayrı tür olduğu için ayrı fabrikalarda üretiliyor
            //
            AFactory aFactory = new AFactory();
            var aproduct = (AProduct)aFactory.CreateProduct(2000, "Kırmızı");
            
            
            BFactory bFactory = new BFactory();


        }
    }
}
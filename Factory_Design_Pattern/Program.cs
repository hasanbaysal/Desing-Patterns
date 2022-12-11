using Factory_Design_Pattern.Concreate_Factory;
using Factory_Design_Pattern.Concreate_Product;

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

            Console.WriteLine(aproduct.Color + " " + aproduct.Price);
            
            BFactory bFactory = new BFactory();

            var bproduct = (BProduct)bFactory.CreateProduct(3000,"Sarı");
            Console.WriteLine(bproduct.Color + " " + bproduct.Price);


        }
    }
}
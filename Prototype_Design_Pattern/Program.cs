namespace Prototype_Design_Pattern
{

    /*
        Bu  tasarım deseni ile elimizde olan nesne şablonlarını new'lemden klonluyoruz
        nesne yaratma süreçlerinde işlemlerimizi kolaylaştırıyor yerine göre performans açısından da 
        bizlere kolaylıklar sağlıyor.
        
                           BURADA DİKKAT EDİLMESİ GEREK YER !!
        kopyalama işlemleri yüzelsel yahut derin olabiliyor. Bu konuda dotnet içinde
        shallow copy ve deep copy kavramlarına bakmanız gerekiyor
     
     */

    internal class Program
    {
        
        public static void Main(string[] args)
        {
            List<IGameCharacter> characters = new List<IGameCharacter>();
            Hero hero1 = new Hero() { Type="hero",ClanName = "X", Hp = 100, Name = "hero1", Str = 99 };
            Hero hero2 = new Hero() { Type="hero",ClanName = "Y", Hp = 80, Name = "hero2", Str = 90 };
            Npc npc1 = new Npc() { Type="npc",X_Coordinate = 100, Y_Coordinate = 300, Name = "npc1" };
            characters.Add(hero1);
            characters.Add(hero2);
            characters.Add(npc1);

            

            Console.WriteLine("Elimize Bulunun mevcut karakterler listesi");
            characters.ForEach(x => Console.WriteLine($"{x.Type} {x.Name}"));
            Console.WriteLine("klonlama işleminden sonra elimizde olan ");

            characters.Add((Hero)hero1.Clone());
            characters.Add((Hero)hero1.Clone());
            characters.Add((Hero)hero1.Clone());
            characters.Add((Hero)hero2.Clone());
            characters.Add((Hero)hero2.Clone());
            characters.Add((Npc)npc1.Clone());
            characters.Add((Npc)npc1.Clone());
            characters.Add((Npc)npc1.Clone());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            

            characters.ForEach(x => Console.WriteLine($"{x.Type} {x.Name}"));

        }

    }
}
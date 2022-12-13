namespace Builder_Design_Pattern
{

    internal class Program
    {
        static void Main(string[] args)
        {
            ProductBuilder productBuilder = new ProductBuilder();
            productBuilder.BuilderPart(new string[] { "a", "b", "c" }, new Product1());
            var pr =(Product1) productBuilder.GetProduct();
            pr.ProductFeatures.ForEach(x => Console.WriteLine($"{x}"));

            Console.WriteLine();

            ProductBuilder productBuilder2 = new ProductBuilder();
            productBuilder2.BuilderPart(new string[] { "x", "y", "z" }, new Product1());
            var pr2 = (Product1)productBuilder2.GetProduct();


            pr2.ProductFeatures.ForEach(x => Console.WriteLine($"{x}"));

        }
    }
}
namespace Iterator_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ExampleEntityCollection collection = new ExampleEntityCollection();

            var iterator = (ExampleIterator)collection.GetEnumerator();

            while (iterator.MoveNext())
            {
                var temp = (ExampleEntity)iterator.Current;
                Console.WriteLine($"id : {temp._id}  name : {temp.Price}");

            }
            Console.WriteLine("---------------------------------------------------");
            foreach (ExampleEntity item in collection)
            {
                Console.WriteLine($"id : {item._id}  name : {item.Price}");

            }

        }
    }


}
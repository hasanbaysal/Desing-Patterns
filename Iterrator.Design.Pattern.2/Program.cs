namespace Iterrator.Design.Pattern._2
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            SoftwareDepartment softwareDepartment = new SoftwareDepartment();
            var iitr = softwareDepartment.GetIterator();
            PrintAllData(iitr);

        }

        private static void PrintAllData(Iterator iitr)
        {
            while (iitr.Next())
            {

                dynamic item = iitr.GetItem();

                Console.WriteLine(item.Name);
            }
        }
    }
}
namespace Iterrator.Design.Pattern._2
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            SoftwareDepartment softwareDepartment = new SoftwareDepartment();
            var iitr = softwareDepartment.GetIterator();
            PrintAllData(iitr);
            Console.WriteLine();
            SalesDepartment salesDepartment = new SalesDepartment();
            var itr2 = salesDepartment.GetIterator();
            PrintAllData(itr2);
        }

        private static void PrintAllData(Iterator itr)
        {
            while (itr.Next())
            {

                dynamic item = itr.GetItem();

                Console.WriteLine($"id: {item.Id}   name: {item.Name}   salary :{item.Salary}$ ");
            }
        }
    }
}
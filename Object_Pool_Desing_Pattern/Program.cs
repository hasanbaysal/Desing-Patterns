namespace Object_Pool_Desing_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Connection c1 = new Connection();
            c1.Open();
            c1.Execute("c1 select ......");
            c1.Close();

            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine();


            Connection c2 = new Connection();
            c2.Open();
            c2.Execute("c1 select ......");
            c2.Close();

        }
    }
}

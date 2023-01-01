namespace Iterrator.Design.Pattern._2
{
    internal partial class Program
    {
        public class SalesDepartment:Iterable
        {
            private Worker[] _workers;

            internal Worker[] Workers { get => _workers; set => _workers = value; }

            public SalesDepartment()
            {
                _workers = new Worker[5];

                _workers[0] = new Worker() { Id = 1, Name = "ahmet", Salary = 1000 };
                _workers[1] = new Worker() { Id = 2, Name = "ali", Salary = 1000 };
                _workers[2] = new Worker() { Id = 3, Name = "ayşe", Salary = 1000 };
                _workers[3] = new Worker() { Id = 4, Name = "zeynep", Salary = 1000 };
                _workers[4] = new Worker() { Id = 5, Name = "ismail", Salary = 1000 };

            }

            public Iterator GetIterator()
            {
                return new ArrayIterator(this);
            }
        }
    }
}
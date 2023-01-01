namespace Iterrator.Design.Pattern._2
{
    internal partial class Program
    {
        public class SoftwareDepartment:Iterable
        {
            private  List<Worker> _workers;
            public List<Worker> Workers { get => _workers; set => _workers = value; }

            public SoftwareDepartment()
            {
                _workers = new List<Worker>();

                _workers.Add(new Worker() { Id = 1, Name = "ahmet", Salary = 1000 });
                _workers.Add(new Worker(){ Id = 2, Name = "ali", Salary = 1000 });
                _workers.Add(new Worker(){ Id = 3, Name = "ayşe", Salary = 1000 });
                _workers.Add( new Worker() { Id = 4, Name = "zeynep", Salary = 1000 });
                _workers.Add(new Worker() { Id = 5, Name = "ismail", Salary = 1000 });

            }

            
            public Iterator GetIterator()
            {
                return new ListIterator(this);
            }
        }
    }
}
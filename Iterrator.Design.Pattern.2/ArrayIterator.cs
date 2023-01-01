namespace Iterrator.Design.Pattern._2
{
    internal partial class Program
    {
        public class ArrayIterator : Iterator
        {

            private int _index = 0;
            private SalesDepartment _salesDepartment;

            public ArrayIterator(SalesDepartment salesDepartment)
            {
                _salesDepartment = salesDepartment;
            }

         
            public object GetItem()
            {
                return _salesDepartment.Workers[_index++];
            }

            public bool Next()
            {
                return _index < _salesDepartment.Workers.Length;

            }
        }
    }
}
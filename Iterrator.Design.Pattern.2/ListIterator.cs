namespace Iterrator.Design.Pattern._2
{
    internal partial class Program
    {
        public class ListIterator : Iterator
        {
            private int _index=0;

            private SoftwareDepartment _salesDepartment;

            public ListIterator(SoftwareDepartment salesDepartment)
            {
                _salesDepartment = salesDepartment;
            }

           
            public object GetItem()
            {
                return _salesDepartment.Workers[_index++];
            }

            public bool Next()
            {
               return _index < _salesDepartment.Workers.Count;
            }

        }
    }
}
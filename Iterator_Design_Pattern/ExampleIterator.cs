using System.Collections;

namespace Iterator_Design_Pattern
{
    public class ExampleIterator : IEnumerator
    {
        private int _index = -1;
        private ExampleEntityCollection _collection;

        public ExampleIterator(ExampleEntityCollection collection)
        {
            _collection = collection;
        }

        public object Current
        {
            get { return _collection.Items[_index]; }
        }

        public bool MoveNext()
        {
            if (_index < _collection.Items.Length-1)
            {
                ++_index;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Reset()
        {
            _index =0;
        }
    }


}
using System.Collections;

namespace Iterator_Design_Pattern
{
    public class ExampleEntityCollection : IEnumerable
    {
        private ExampleEntity[] exampleEntities;

        public ExampleEntity[] Items { get {

                return exampleEntities;
            
            } }

        public ExampleEntityCollection()
        {
            exampleEntities = new ExampleEntity[5];

            exampleEntities[0] = new ExampleEntity() { _id = 1, Price = 100 };
            exampleEntities[1] = new ExampleEntity() { _id = 2, Price = 200 };
            exampleEntities[2] = new ExampleEntity() { _id = 3, Price = 300 };
            exampleEntities[3] = new ExampleEntity() { _id = 4, Price = 400 };
            exampleEntities[4] = new ExampleEntity() { _id = 5, Price = 500 };



        }
      
        public IEnumerator GetEnumerator()
        {
            return new ExampleIterator(this);
        }
    }


}
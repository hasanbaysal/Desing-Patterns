namespace Builder_Design_Pattern
{
    public class ProductBuilder : IBuilder
    {
        
        public override void BuilderPart(string[] partsofItem, Product pr)
        {
            this.Product = pr;
            this.Product.ProductFeatures.AddRange(partsofItem);
        }

        public override Product GetProduct()
        {
            return this.Product;
        }
    }
}
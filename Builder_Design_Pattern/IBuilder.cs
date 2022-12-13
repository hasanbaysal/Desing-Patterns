namespace Builder_Design_Pattern
{
    /*
         Bu desen adını komposit
        nesneleri, alt parçalarını bir araya 
        getirerek oluşturmaya bir çözüm 
        getirmesinden almaktadır
     
     */

    public abstract class IBuilder
    {
        protected Product Product { get; set; }
        public abstract void BuilderPart(string [] partsofItem , Product product);
        public abstract Product GetProduct();
    }
}
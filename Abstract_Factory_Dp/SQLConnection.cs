namespace Abstract_Factory_Dp
{
    public class SqlConnection : Connection
    {
        protected override string ConnectionString { get; set; }

        public override void Connect()
        {
            Console.WriteLine("connected to sql server");
        }
    }
}
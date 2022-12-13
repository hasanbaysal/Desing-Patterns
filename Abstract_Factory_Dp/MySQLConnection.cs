namespace Abstract_Factory_Dp
{
    public class MySQlConnection : Connection
    {
        protected override string ConnectionString { get; set; }
        public override void Connect()
        {
            Console.WriteLine("connected to MySql server");
        }
    }
}
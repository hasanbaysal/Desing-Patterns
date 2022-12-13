namespace Abstract_Factory_Dp
{
    public abstract class  Connection
    {
        public abstract void Connect();
        protected string connectionString;

         protected abstract string ConnectionString { get; set; }
    }
}
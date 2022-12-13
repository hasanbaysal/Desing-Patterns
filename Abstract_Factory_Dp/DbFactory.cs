namespace Abstract_Factory_Dp
{
    public abstract class DbFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }
}
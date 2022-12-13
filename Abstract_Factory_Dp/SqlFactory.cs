namespace Abstract_Factory_Dp
{
    public class SqlFactory : DbFactory
    {
        public override Command CreateCommand()
        {
            return new SQLCommand();
        }

        public override Connection CreateConnection()
        {
            return new SqlConnection();
        }
    }
}
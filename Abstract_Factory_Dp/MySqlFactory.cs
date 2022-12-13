namespace Abstract_Factory_Dp
{
    public class MySqlFactory : DbFactory
    {
        public override Command CreateCommand()
        {
            return new MYSqlCommand();
        }
        
        public override Connection CreateConnection()
        {
            return new MySQlConnection();
        }
    }
}
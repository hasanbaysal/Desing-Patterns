namespace Abstract_Factory_Dp
{

    public static class FactoryProvider
    {

        public static DbFactory GetDbFactory(string factory)
        {
            switch (factory)
            {
                case "Sql":
                    return new SqlFactory();

                case "MySql":
                    return new MySqlFactory();

                default:
                    return null;
                    break;
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            DbFactory db = FactoryProvider.GetDbFactory("Sql");
            Connection cn = db.CreateConnection();
            cn.Connect();
            Command cmd = db.CreateCommand();
            cmd.Execute();


            DbFactory db2 = FactoryProvider.GetDbFactory("MySql");
            Connection cn2 = db2.CreateConnection();
            cn2.Connect();
            Command cmd2 = db2.CreateCommand();
            cmd2.Execute();




        }
    }
}
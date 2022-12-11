namespace Object_Pool_Desing_Pattern
{
    public class PoolManager
    {

        //poolmanager'in obje havuzumuzu yönetmesinden dolayı bir tane olmasını isteriz
        //o yüzden singelton tasarlayacağız poolmanager'i

        private int _count = 10;
        private static PoolManager _poolManager;
        private List<ConnectionConntext> connectionsPool;
        private int open;
        private int close;

        private PoolManager()
        {
            connectionsPool = new List<ConnectionConntext>();
            for (int i = 0; i < _count; i++)
            {
                connectionsPool.Add(new ConnectionConntext() { ConnectionName = "con" + i });
            }
        }
        public static PoolManager CreatePool()
        {
            if (_poolManager == null)
            {
                _poolManager = new PoolManager();
                return _poolManager;
            }
            return _poolManager;
        }
        public  ConnectionConntext GetOneConnection()
        {
            for (int i = 0; i < connectionsPool.Count; i++)
            {
                if (!connectionsPool[i].IsActive)
                {
                    connectionsPool[i].IsActive = true;

                   close= connectionsPool.Where(x => x.IsActive == false).Count();
                    Console.WriteLine($"boşta {close} adet connection nesnesi kaldı");
                    return connectionsPool[i];

                }
            }

            return null;
        }
        public void ReleaseConnection(ConnectionConntext con)
        {
            con.IsActive = false;

            close = connectionsPool.Where(x => x.IsActive == false).Count();
            Console.WriteLine($"boşta {close} adet connection nesnesi kaldı");

        }

    }
}
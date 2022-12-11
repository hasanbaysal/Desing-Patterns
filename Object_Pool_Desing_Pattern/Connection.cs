using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Pool_Desing_Pattern
{
    internal class Connection
    {
        private ConnectionConntext connection;
        private PoolManager pool;
        public void Open()
        {
            if (connection != null && connection.IsActive)
            {
                Console.WriteLine("zaten açık bir bağlantı");
                return;
            }

            pool= PoolManager.CreatePool();
           connection = pool.GetOneConnection();
            if (connection == null)
            {
                Console.WriteLine("havuzda boş nesne yok");
                return;
            }
            
            connection.Open();
        }
        public void Close()
        {
            pool.ReleaseConnection(connection);
           connection.Close();
           
        }
        public void Execute(string query)
        {
            connection.Execute(query);

        }



    }
}

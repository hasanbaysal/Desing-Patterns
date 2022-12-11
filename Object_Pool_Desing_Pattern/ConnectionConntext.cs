namespace Object_Pool_Desing_Pattern
{
    public class ConnectionConntext
    {
        public string ConnectionName { get; set; }
        public string ConnectionString { get; set; }

        public bool IsActive { get; set; }

        public void Open()
        {
            Console.WriteLine($"-{this.ConnectionName} açıldı ");
            IsActive = true;
        }
        public void Close()
        {
            Console.WriteLine($"-{this.ConnectionName} : kapandı");
            IsActive = false;
        }

        public void Execute(string cmd)
        {
            Console.WriteLine($"-{this.ConnectionName} : {cmd} komutunu çalıştırdı");
          
        }

    }
}
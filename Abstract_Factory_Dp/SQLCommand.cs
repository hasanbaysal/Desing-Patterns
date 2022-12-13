namespace Abstract_Factory_Dp
{
    public class SQLCommand : Command{
            public override string Query
            {
                get{return base.query;}
                set
                {base.query = value;}
            
            }


        public override void Execute()
        {
            Console.WriteLine("SQL komutu çalıştı.");
            }
        
    
    }
}
namespace Abstract_Factory_Dp
{
    public abstract class Command
    {
        public abstract void Execute();
         protected string query;

        public abstract string Query { get; set; }
    }
}
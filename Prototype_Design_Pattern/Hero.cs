namespace Prototype_Design_Pattern
{
    public class Hero : IGameCharacter
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string ClanName { get; set; }
        public int Hp { get; set; }
        public int Str { get; set; }
       
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
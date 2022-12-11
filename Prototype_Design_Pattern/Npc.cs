namespace Prototype_Design_Pattern
{
    public class Npc : IGameCharacter
    {
        public int X_Coordinate { get; set; }
        public int Y_Coordinate { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
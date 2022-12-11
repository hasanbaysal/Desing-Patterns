namespace Prototype_Design_Pattern
{
    public interface IGameCharacter
    {
        public string Type { get; set; }
        public string Name { get; set; }
        object Clone();
    }
}
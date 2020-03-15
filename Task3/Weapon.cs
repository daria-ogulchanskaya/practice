namespace Task3
{
    public class Weapon
    {
        public Type Type { get; }
        public int Level { get; }

        public Weapon(Type type)
        {
            Level = 1;
            Type = type;
        }
    }
}

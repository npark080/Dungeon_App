namespace DungeonLibrary
{
    public sealed class NoOne : Monster
    {

        public NoOne(string name, int hitChance, int block, int maxLife,
            int life, int maxDamage, int minDamage, string description, int affection)
            : base(name, hitChance, block, maxLife, life, maxDamage, minDamage, description, affection)
        {

        }
        public override string ToString()
        {
            return "There's no one here...";
        }
    }
}

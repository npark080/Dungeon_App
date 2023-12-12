namespace DungeonLibrary
{
    public sealed class Witch : Monster
    {

        public Witch(string name, int hitChance, int block, int maxLife,
            int life, int maxDamage, int minDamage, string description, int affection)
            : base(name, hitChance, block, maxLife, life, maxDamage, minDamage, description, affection)
        {
            
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override int CalcAffection()
        {
            return 0;
        }
    }
}

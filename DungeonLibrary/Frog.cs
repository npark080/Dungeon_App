namespace DungeonLibrary
{
    public sealed class Frog : Monster
    {
        public bool Slimy { get; set; }
        public bool Poisonous { get; set; }

        public Frog(string name, int hitChance, int block, int maxLife,
            int life, int maxDamage, int minDamage, string description, int affection, bool slimy, bool poisonous)
            : base(name, hitChance, block, maxLife, life, maxDamage, minDamage, description, affection)
        {
            Slimy = slimy;
            Poisonous = poisonous;
        }
        public override string ToString()
        {
            return base.ToString() + (Slimy ? "Slimy" : "Normal");
        }

        //Sliminess add 50% block
        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (Slimy)
            {
                calculatedBlock += (calculatedBlock / 2);
            }

            return calculatedBlock;
        }
    }
}
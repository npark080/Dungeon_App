namespace DungeonLibrary
{
    public sealed class Snake : Monster
    {
        public bool Rattle { get; set; }
        public static bool Poisonous { get; set; }

        public Snake(string name, int hitChance, int block, int maxLife,
            int life, int maxDamage, int minDamage, string description, int affection, bool rattle, bool poisonous)
            : base(name, hitChance, block, maxLife, life, maxDamage, minDamage, description, affection)
        {
            Rattle = rattle;
            Poisonous = poisonous;
        }
        public override string ToString()
        {
            return base.ToString() + (Rattle ? "Rattle" : "Normal");
        }

        //Rattle add 50% to max damage
        public override int CalcDamage()
        {
            int calculatedMaxDamage = MaxDamage;

            if (Rattle)
            {
                calculatedMaxDamage += (calculatedMaxDamage / 2);
            }

            return calculatedMaxDamage;
        }

        //Rattle add 50% block
        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (Rattle)
            {
                calculatedBlock += (calculatedBlock / 2);
            }

            return calculatedBlock;
        }
    }
}

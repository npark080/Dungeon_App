namespace DungeonLibrary
{
    public sealed class Deer : Monster
    {
        public bool Buck { get; set; }

        public Deer(string name, int hitChance, int block, int maxLife,
            int life, int maxDamage, int minDamage, string description, int affection, bool buck)
            : base(name, hitChance, block, maxLife, life, maxDamage, minDamage, description, affection)
        {
            Buck = buck;
        }
        public override string ToString()
        {
            return base.ToString() + (Buck ? "Buck" : "Deer");
        }

        //Bucks add 50% to max damage
        public override int CalcDamage()
        {
            int calculatedMaxDamage = MaxDamage;

            if (Buck)
            {
                calculatedMaxDamage += (calculatedMaxDamage / 2);
            }

            return calculatedMaxDamage;
        }

        //Bucks add 50% block
        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (Buck)
            {
                calculatedBlock += (calculatedBlock / 2);
            }

            return calculatedBlock;
        }
    }
}

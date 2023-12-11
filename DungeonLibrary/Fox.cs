namespace DungeonLibrary
{
    public sealed class Fox : Monster
    {
        public bool Tamed { get; set; }

        public Fox(string name, int hitChance, int block, int maxLife,
            int life, int maxDamage, int minDamage, string description, int affection, bool tamed)
            : base(name, hitChance, block, maxLife, life, maxDamage, minDamage, description, affection)
        {
            Tamed = tamed;
        }
        public override string ToString()
        {
            return base.ToString() + (Tamed ? "Tamed" : "Wild");
        }

        //Tamed foxes do 25% less max damage
        public override int CalcDamage()
        {
            int calculatedMaxDamage = MaxDamage;

            if (Tamed)
            {
                calculatedMaxDamage -= (calculatedMaxDamage / 4);
            }

            return calculatedMaxDamage;
        }

        //Tamed foxes block 25% less damange
        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (Tamed)
            {
                calculatedBlock -= (calculatedBlock / 4);
            }

            return calculatedBlock;
        }
    }
}

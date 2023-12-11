namespace DungeonLibrary
{
    public class Bee : Monster
    {
        public bool Bumbling { get; set; }

        public Bee(string name, int hitChance, int block, int maxLife,
            int life, int maxDamage, int minDamage, string description, int affection, bool bumbling)
            : base(name, hitChance, block, maxLife, life, maxDamage, minDamage, description, affection)
        {
            Bumbling = bumbling;
        }

        public override string ToString()
        {
            return base.ToString() + (Bumbling ? "Bumbling" : "Normal");
        }

        //Bumbling bees have calculated block halved
        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (Bumbling)
            {
                calculatedBlock -= (calculatedBlock / 2);
            }

            return calculatedBlock;
        }

        //Bumbling bees have half as much chance to land a strike
        public override int CalcHitChance()
        {
            int calculatedHitChance = HitChance;

            if (Bumbling)
            {
                calculatedHitChance -= (calculatedHitChance / 2);
            }

            return calculatedHitChance;
        }
    }
}

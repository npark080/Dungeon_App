namespace DungeonLibrary
{
    public sealed class Rabbit : Monster
    {
        public bool Fluffy { get; set; }

        public Rabbit(string name, int hitChance, int block, int maxLife,
            int life, int maxDamage, int minDamage, string description, int affection, bool fluffy)
            : base(name, hitChance, block, maxLife, life, maxDamage, minDamage, description, affection)
        {
            Fluffy = fluffy;
        }
        public override string ToString()
        {
            return base.ToString() + (Fluffy ? "Fluffy" : "Normal");
        }

        public override int CalcBlock()
        {
            //return base.CalcBlock();

            int calculatedBlock = Block;

            //Apply a 50% increase to rabbit's block if it's fluffy
            if (Fluffy)
            {
                calculatedBlock += (calculatedBlock / 2);
            }

            return calculatedBlock;
        }
    }
}
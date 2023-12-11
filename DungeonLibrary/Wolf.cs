namespace DungeonLibrary
{
    public sealed class Wolf : Monster
    {
        public bool Bad { get; set; }

        public Wolf(string name, int hitChance, int block, int maxLife,
            int life, int maxDamage, int minDamage, string description, int affection, bool bad)
            : base(name, hitChance, block, maxLife, life, maxDamage, minDamage, description, affection)
        {
            Bad = bad;

            if (bad)
            {
                Block += 10;
                MinDamage = 0;
                MaxDamage = 0;
            }
        }

        public override string ToString()
        {
            //return base.ToString();

            return string.Format("{0}\n{1}",
                base.ToString(),
                Bad ? "Huffing & Puffing" :
                "Normal");
        }

        //Bad wolves are half as affected by trying to win them over
        public override int CalcAffection()
        {
            int calculatedAffection = Affection;

            if (Bad)
            {
                calculatedAffection -= (calculatedAffection / 2);
            }

            return calculatedAffection;
        }
    }
}

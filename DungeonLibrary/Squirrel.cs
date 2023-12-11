namespace DungeonLibrary
{
    public sealed class Squirrel : Monster
    {
        public bool Rabid { get; set; }

        public Squirrel(string name, int hitChance, int block, int maxLife,
            int life, int maxDamage, int minDamage, string description, int affection, bool rabid)
            : base(name, hitChance, block, maxLife, life, maxDamage, minDamage, description, affection)
        {
            Rabid = rabid;
        }
        public override string ToString()
        {
            return base.ToString() + (Rabid ? "Rabid" : "Normal");
        }

        //Rabid squirrels add 50% to max damage
        public override int CalcDamage()
        {
            int calculatedMaxDamage = MaxDamage;

            if (Rabid)
            {
                calculatedMaxDamage += (calculatedMaxDamage / 2);
            }

            return calculatedMaxDamage;
        }

        //Rabid squirrels are less accurate
        public override int CalcHitChance()
        {
            int calculatedHitChance = HitChance;
            if (Rabid)
            {
                calculatedHitChance -= (calculatedHitChance / 2);
            }

            return calculatedHitChance;
        }
    }
}

namespace DungeonLibrary
{
    public sealed class Bear : Monster
    {
        public int SecondAttack { get; set; }

        public int SecondAttackPercent { get; set; }

        public bool Honey { get; set; }

        public Bear(string name, int hitChance, int block, int maxLife, int life,
            int maxDamage, int minDamage, string description, int affection, int secondAttack, int secondAttackPercent, bool honey)
            : base(name, hitChance, block, maxLife, life, maxDamage, minDamage, description, affection)
        {
            SecondAttack = secondAttack;
            SecondAttackPercent = secondAttackPercent;
            Honey = honey;
        }

        public override string ToString()
        {
            return String.Format("{0}\n% chance it will attack again, granting {2} damage.",
                base.ToString(), SecondAttackPercent, SecondAttack);
        }

        public override int CalcDamage()
        {
            //return base.CalcBlock();

            int calculatedDamage = CalcDamage();

            Random rand = new Random();

            int percent = rand.Next(101);

            //Check if percent is less than or equal to the hide percent
            if (percent <= SecondAttackPercent)
            {
                //If it is, add the bonus block
                calculatedDamage += SecondAttack;
            }

            return calculatedDamage;
        }
    }
}

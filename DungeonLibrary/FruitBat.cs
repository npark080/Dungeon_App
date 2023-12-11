namespace DungeonLibrary
{
    public sealed class FruitBat : Monster
    {
        public DateTime TimeOfDay { get; set; }

        public FruitBat(string name, int hitChance, int block, int maxLife,
            int life, int maxDamage, int minDamage, string description, int affection)
            : base(name, hitChance, block, maxLife, life, maxDamage, minDamage, description, affection)
        {
            TimeOfDay = DateTime.Now;

            //At night, our Vampire becomes significantly more dangerous
            if (TimeOfDay.Hour < 6 || TimeOfDay.Hour > 18)
            {
                HitChance += 15;
                Block += 15;
                MinDamage += 1;
                MaxDamage += 2;
            }
        }

        public override string ToString()
        {
            //return base.ToString();

            return string.Format("{0}\n{1}",
                base.ToString(),
                TimeOfDay.Hour < 6 || TimeOfDay.Hour > 18 ? "Alert" :
                "Sleepy");

        }
    }
}

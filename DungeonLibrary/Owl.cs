namespace DungeonLibrary
{
    public sealed class Owl : Monster
    {
        public DateTime TimeOfDay { get; set; }

        public Owl(string name, int hitChance, int block, int maxLife,
            int life, int maxDamage, int minDamage, string description, int affection)
            : base(name, hitChance, block, maxLife, life, maxDamage, minDamage, description, affection)
        {
            TimeOfDay = DateTime.Now;

            //Owls are more dangerous at night
            if (TimeOfDay.Hour < 6 || TimeOfDay.Hour > 18)
            {
                HitChance += 10;
                Block += 10;
                MinDamage += 2;
                MaxDamage += 3;
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
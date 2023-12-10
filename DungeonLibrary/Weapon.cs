namespace DungeonLibrary
{
    public sealed class Weapon
    {
        //FIELDS
        private int _minDamage;

        //PROPERTIES
        public int MaxDamage { get; set; }

        public string Name { get; set; }

        public int BonusHitChance { get; set; }
        
        public WeaponType Type { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }

        //CONSTRUCTORS
        public Weapon(string name, int maxDamage, int minDamage, int bonusHitChance, WeaponType type)
        {
            Name = name;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            BonusHitChance = bonusHitChance;
            Type = type;
        }

        //METHODS
        public override string ToString()
        {
            return string.Format($"{Name}\nType: {Type}\nDamage: {MinDamage}-{MaxDamage}\nBonus Hit Chance: {BonusHitChance}");
        }
    }
}

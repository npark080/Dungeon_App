namespace DungeonLibrary
{
    public abstract class Monster : Character
    {
        //FIELDS
        private int _minDamage;

        //PROPERTIES
        public int MaxDamage { get; set; }
        public string Description { get; set; }
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
        public Monster(string name, int maxLife, int hitChance, int block, int life, int maxDamage, int minDamage, string description)
            : base(name, maxLife, hitChance, block, life)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }

        //METHODS
        public override string ToString()
        {
            return base.ToString() + "\nDamage: " + MinDamage + " - " + MaxDamage +
                "Description: " + Description;
        }

        public override int CalcDamage()
        {
            Random rng = new Random();
            return rng.Next(MinDamage, MaxDamage + 1);
        }
    }
}

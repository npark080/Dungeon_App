namespace DungeonLibrary
{
    public abstract class Monster : Character
    {
        //FIELDS
        private int _minDamage;
        private int _affection;

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
        public int Affection
        {
            get { return _affection; }
            set
            {
                if (value >= 0 )
                {
                    _affection = value;
                }
                else if (value > 100)
                {
                    _affection = 100;
                }
                else
                {
                    _affection = 0;
                }
            }
        }

        //CONSTRUCTORS
        public Monster(string name, int maxLife, int hitChance, int block, int life, int maxDamage, int minDamage, string description, int affection)
            : base(name, maxLife, hitChance, block, life)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
            Affection = affection;
        }

        //METHODS
        public override string ToString()
        {
            return base.ToString() + "\nAffection: " + Affection + "\nDamage: " + MinDamage + " - " + MaxDamage +
                "\nDescription: " + Description + "\n";
        }

        public override int CalcDamage()
        {
            Random rng = new Random();
            return rng.Next(MinDamage, MaxDamage + 1);
        }

        public virtual int CalcAffection()
        {
            return 0;
        }
    }
}

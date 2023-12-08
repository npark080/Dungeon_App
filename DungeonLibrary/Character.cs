namespace DungeonLibrary
{
    public abstract class Character
    {
        //FIELDS
        private int _life;

        //PROPERTIES
        public string Name { get; set; }

        public int HitChance { get; set; }

        public int Block { get; set; }

        public int MaxLife { get; set; }

        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }

                else
                {
                    _life = MaxLife;
                }
            }
        }

        public Character(string name, int maxLife, int hitChance, int block, int life)
        {
            Name = name;
            MaxLife = maxLife;
            HitChance = hitChance;
            Block = block;
            Life = life;
        }

        public override string ToString()
        {
            return string.Format($"{Name}\nHP: {Life}/{MaxLife}\nHit Chance: {HitChance}\nBlock: {Block}");
        }

        public virtual int CalcBlock()
        {
            return Block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            return 0;
        }

    }
}
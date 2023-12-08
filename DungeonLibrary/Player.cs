using System.Diagnostics;

namespace DungeonLibrary
{
    public sealed class Player : Character
    {
        //FIELDS

        //PROPERTIES
        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }

        //CONSTRUCTORS

        public Player(string name, int maxLife, int hitChance, int block, int life, Race characterRace, Weapon equippedWeapon)
            : base(name, maxLife, hitChance, block, life)
        {
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
        }
        #region Customization Option - Racial Bonuses

        //TODO Racial Bonus

        #endregion

        //METHODS

        public override string ToString()
        {
            return base.ToString() + "\nRace: " + CharacterRace +
                "\nWeapon: " + EquippedWeapon;
        }

        public override int CalcDamage()
        {
            Random rng = new Random();
            int dmg = rng.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return dmg;
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }
    }
}

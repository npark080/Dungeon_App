namespace DungeonLibrary
{
    public sealed class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            Random rand = new Random();
            int roll = rand.Next(1, 101);

            System.Threading.Thread.Sleep(30);

            //If the attacker "hits"
            if (roll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //Calculate the damage
                int damageDealt = attacker.CalcDamage();

                //Subtract & assign the damage to the defender's life
                defender.Life -= damageDealt;

                Console.WriteLine("{0} hit {1} for {2} damage.",
                    attacker.Name, defender.Name, damageDealt);
            }
            //If the attacker "misses"
            else
            {
                Console.WriteLine("{0} missed.", attacker.Name);
            }
        }

        public static void DoBattle(Player player, Monster monster)
        {
            DoAttack(player, monster);

            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }
        }

        public static void DoBattleBee(Player player, Monster monster)
        {
            DoAttack(player, monster);
            if (monster.Life > 5)
            {
                Console.WriteLine("The bee buzzes at you in the most intimidating way possible.");
            }
            if (monster.Life <= 5 && monster.Life > 0)
            {
                Console.WriteLine("Realizing it's close to perishing, the bee uses it's last resort and hones in with it's stinger.");
                DoAttack(monster, player);
                monster.Life = 0;
            }
            if (monster.Life <= 0)
            {
                Console.WriteLine("The bee withered away.  Left behind, it's stinger sits less menacingly on the ground.  You pick it up and feel slightly more powerful.");
                player.EquippedWeapon.MaxDamage += 5;
                player.EquippedWeapon.MinDamage += 2;
            }
        }
    }
}

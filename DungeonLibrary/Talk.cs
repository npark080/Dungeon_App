namespace DungeonLibrary
{
    public sealed class Talk
    {
        public static void TalkBee(Player player, Monster monster)
        {
            Console.WriteLine("You try sweet talking the bee.");
            if (monster.Affection <= 33)
            {
                Console.WriteLine("The bee stares at you for a second thinking you're ill in the head.");
                Combat.DoAttack(monster, player);
                monster.Affection += 15;
            }
            if (monster.Affection > 33 && monster.Life <= 66 )
            {
                Console.WriteLine("The bee wonders to itself what it should have for dinner tonight.");
                Combat.DoAttack(monster, player);
                monster.Affection += 15;
            }
            if (monster.Affection > 66 && monster.Life < 100)
            {
                Console.WriteLine("The bee quite likes what it's hearing but it's not ready to give up.");
                Combat.DoAttack(monster, player);
                monster.Affection += 20;
            }
            else
            {
                Console.WriteLine("The bee's always been a sucker for sweet talk.  To thank you, it gave you some honey.");
            }
        }
        public static void DoTalk(Player player, Monster monster)
        {
            Console.WriteLine($"You try reasoning with the {monster.Name.ToLower()}.");
            if (monster.Affection <= 33)
            {
                Console.WriteLine($"The {monster.Name.ToLower()} stares at you.");
                Combat.DoAttack(monster, player);
                monster.Affection += 15;
            }
            else if (monster.Affection > 33 && monster.Life <= 66)
            {
                Console.WriteLine($"The {monster.Name.ToLower()} doesn't really get what it's hearing but they're starting to listen in between trying to kill you.");
                Combat.DoAttack(monster, player);
                monster.Affection += 15;
            }
            else if (monster.Affection > 66 && monster.Life < 100)
            {
                Console.WriteLine($"The {monster.Name.ToLower()} thinks you make some pretty good points, but is having fun trying to maul you.");
                Combat.DoAttack(monster, player);
                monster.Affection += 20;
            }
        }
    }
}

using DungeonLibrary;

namespace Test
{
    public class Testing
    {
        static void Main(string[] args)
        {
            Rooms.GetRooms();
        }

        static void GetRoom()
        {
            MonsterWarehouse.GetMonster();
            List<Monster> safeMonsters = new List<Monster>();
            safeMonsters.Add(MonsterWarehouse.GetMonster(bee1));
            safeMonsters.Add(bee2);
            safeMonsters.Add(bee3);
            safeMonsters.Add(rabbit1);
            safeMonsters.Add(rabbit2);
            safeMonsters.Add(rabbit3);
            safeMonsters.Add(squirrel1);
            safeMonsters.Add(squirrel2);
            safeMonsters.Add(squirrel3);
            safeMonsters.Add(deer1);
            safeMonsters.Add(deer2);
            safeMonsters.Add(deer3);

            List<Monster> waterMonsters = new List<Monster>();
            waterMonsters.Add(frog1);
            waterMonsters.Add(frog2);
            waterMonsters.Add(frog3);
            waterMonsters.Add(snake1);
            waterMonsters.Add(snake2);
            waterMonsters.Add(snake3);
            waterMonsters.Add(rabbit1);
            waterMonsters.Add(rabbit2);
            waterMonsters.Add(rabbit3);
            waterMonsters.Add(squirrel1);
            waterMonsters.Add(squirrel2);
            waterMonsters.Add(squirrel3);
            waterMonsters.Add(deer1);
            waterMonsters.Add(deer2);
            waterMonsters.Add(deer3);

            List<Monster> dangerousMonsters = new List<Monster>();
            dangerousMonsters.Add(owl1);
            dangerousMonsters.Add(owl2);
            dangerousMonsters.Add(owl3);
            dangerousMonsters.Add(snake1);
            dangerousMonsters.Add(snake2);
            dangerousMonsters.Add(snake3);
            dangerousMonsters.Add(fox1);
            dangerousMonsters.Add(fox2);
            dangerousMonsters.Add(fox3);
            dangerousMonsters.Add(wolf1);
            dangerousMonsters.Add(wolf2);
            dangerousMonsters.Add(wolf3);
            dangerousMonsters.Add(bear1);
            dangerousMonsters.Add(bear2);
            dangerousMonsters.Add(bear3);

            List<Monster> caveMonsters = new List<Monster>();
            caveMonsters.Add(bear1);
            caveMonsters.Add(bear2);
            caveMonsters.Add(bear3);
            caveMonsters.Add(bat1);
            caveMonsters.Add(bat2);
            caveMonsters.Add(bat3);
            caveMonsters.Add(snake1);
            caveMonsters.Add(snake2);
            caveMonsters.Add(snake3);

#endregion

            #region Room Creation

            string[] rooms =
            {
                    "You step into a forest clearing... it looks oddly like the place you woke up in.",
                    "You come across a babbling brook, just small enough to be quaint but just large enough you can't cross.",
                    "You reach the base of a mountain.  It seemed farther away than it is.",
                    "You struggle through dense woods. It feels like the trees are closing in on you.",
                    "Oh how nice, a mushroom grove.  You wish you paid more attention to herbology and don't dare risk eating a mushroom.",
                    "You wander into a cave.  You can almost feel pressure in the atmosphere.",
                    "You bravely stepped foot in a cabin, the walls are lined with books and potions.  You definitely don't want to be here.",
                    "You stumble upon a lake.  Its serene disposition feels as if it's taunting your grave circumstances.",
                    "You find yourself in the midst of a flower field.  How strange, they're all your favorite colors."
                };
            Random rng = new Random();
            int roomNbr = rng.Next(rooms.Length);
            Console.WriteLine(rooms[roomNbr]);

            if (roomNbr == 0 || roomNbr == 8 || roomNbr == 4)
            {
                Random randMonster = new Random();
                int randNbr = randMonster.Next(safeMonsters.Count);
                Monster chosenMonster = safeMonsters[randNbr];

                Console.WriteLine($"You encounter a {chosenMonster.Name.ToLower()}.");
            }

            else if (roomNbr == 1 || roomNbr == 7)
            {

                Random randMonster = new Random();
                int randNbr = randMonster.Next(waterMonsters.Count);
                Monster chosenMonster = waterMonsters[randNbr];

                Console.WriteLine($"You encounter a {chosenMonster.Name.ToLower()}.");
            }

            else if (roomNbr == 2 || roomNbr == 3)
            {

                Random randMonster = new Random();
                int randNbr = randMonster.Next(dangerousMonsters.Count);
                Monster chosenMonster = dangerousMonsters[randNbr];

                if (chosenMonster == wolf3) { Console.WriteLine("You encounter " + chosenMonster.Name.ToLower()); }
                else { Console.WriteLine($"You encounter a {chosenMonster.Name.ToLower()}"); }
            }

            else if (roomNbr == 5)
            {

                Random randMonster = new Random();
                int randNbr = randMonster.Next(caveMonsters.Count);
                Monster chosenMonster = caveMonsters[randNbr];

                Console.WriteLine($"You encounter a {chosenMonster.Name.ToLower()}.");

            }
        }
    }
}
using DungeonLibrary;
namespace Dungeon
{
    class Program
    {
        private static void Main(string[] args)
        {
            #region Title/Introduction

            //TODO add title & intro

            #endregion

            #region Variable to Keep Score

            //TODO add a variable to keep score

            #endregion

            #region Weapon Object Creation

            //TODO add weapons

            #endregion

            #region Player Object Creation & Customization

            //TODO create player
            //name, race, stats

            #endregion

            #region Main Game Loop
            bool exit = false;

            do
            {
                #region MonsterObject Creation

                Bee bee1 = new("Worker Bee", 90, 60, 15, 15, 15, 10, "Buzzing for a fight", 0, false);
                Bee bee2 = new("Babee", 80, 50, 10, 10, 12, 8, "A sweetie", 20, true);
                Bee bee3 = new("Queenie", 100, 70, 20, 20, 20, 15, "Queen Bee", 0, false);

                Rabbit rabbit1 = new("Bunny", 60, 30, 20, 20, 5, 1, "A cute lil thing", 20, false);
                Rabbit rabbit2 = new("Rabbit", 70, 40, 25, 25, 8, 1, "Just a normal rabbit", 15, false);
                Rabbit rabbit3 = new("Hare", 70, 50, 25, 25, 10, 2, "You can't tell if it's jacked or just fluffy", 15, true);

                Squirrel squirrel1 = new("Squirrel", 50, 30, 20, 20, 5, 2, "It's foaming at the mouth", 0, true);
                Squirrel squirrel2 = new("Squirrel", 70, 25, 25, 25, 8, 2, "It looks kind of sick...", 0, true);
                Squirrel squirrel3 = new("Squirrel", 50, 35, 25, 25, 6, 1, "A fat, healthy squirrel", 20, false);

                FruitBat bat1 = new("Fruit Bat", 60, 50, 20, 20, 5, 1, "Just a bat", 20);
                FruitBat bat2 = new("Fruit Bat", 70, 40, 22, 22, 8, 2, "It's a bat", 15);
                FruitBat bat3 = new("Man...Bat?", 75, 60, 25, 25, 15, 8, "He is vengeance", 0);

                Owl owl1 = new("Owl", 50, 50, 20, 20, 8, 1, "Hoo?", 20);
                Owl owl2 = new("Owl", 40, 30, 25, 25, 10, 2, "Hoo", 10);
                Owl owl3 = new("Owl", 55, 55, 30, 30, 12, 3, "Hoo!", 5);

                Frog frog1 = new("Frog", 50, 50, 15, 15, 5, 1, "What a pretty color", 10, true, true);
                Frog frog2 = new("Toad", 60, 60, 18, 18, 8, 1, "It's eyes are unnerving", 20, true, false);
                Frog frog3 = new("Frog", 70, 60, 15, 15, 6, 2, "What if it's a prince?", 15, false, false);

                Snake snake1 = new("Rattlesnake", 50, 60, 25, 25, 12, 3, "That doesn't sound good", 0, true, false);
                Snake snake2 = new("Snake", 70, 50, 20, 20, 8, 4, "You almost mistook it for a stick", 0, false, true);
                Snake snake3 = new("Snake", 60, 60, 10, 10, 10, 2, "Ssssso Ssssscary", 15, false, false);

                Deer deer1 = new("Doe", 50, 50, 20, 20, 5, 1, "Taking doe-eyed to a new level", 0, false);
                Deer deer2 = new("Fawn", 50, 25, 15, 15, 3, 1, "Bambi?", 25, false);
                Deer deer3 = new("Buck", 60, 60, 25, 25, 15, 8, "What impressive antlers", 0, true);

                Fox fox1 = new("Fox", 60, 70, 25, 25, 10, 2, "On their guard", 0, false);
                Fox fox2 = new("Fox", 60, 70, 25, 25, 10, 2, "Looks like they're waiting for someone", 70, true);
                Fox fox3 = new("Fox", 70, 60, 25, 25, 12, 4, "Don't cuss with him", 0, false);

                Wolf wolf1 = new("Wolf", 60, 60, 30, 30, 15, 4, "A wolf", 0, false);
                Wolf wolf2 = new("Big Bad Wolf", 100, 60, 35, 35, 100, 1, "Huffing and puffing", 0, true);
                Wolf wolf3 = new("Grandma?", 50, 60, 33, 33, 18, 1, "My, what big teeth those are", 0, false);

                Bear bear1 = new("Bear", 40, 60, 40, 40, 15, 10, "Beary Scary", 0, 5, 50, false);
                Bear bear2 = new("Honey Bear", 50, 50, 30, 30, 12, 8, "Doesn't look as sweet as it sounds", 0, 3, 60, true);
                Bear bear3 = new("Mor'du", 50, 50, 50, 50, 20, 10, "You've heard tales of this bear", 0, 10, 40, false);

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
                    List<Monster> safeMonsters = new List<Monster>();
                    safeMonsters.Add(bee1);
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

                    Random randMonster = new Random();
                    int randNbr = randMonster.Next(safeMonsters.Count);
                    Monster chosenMonster = safeMonsters[randNbr];

                    Console.WriteLine($"You encounter a {chosenMonster.Name.ToLower()}.");
                }

                else if (roomNbr == 1 || roomNbr == 7)
                {
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

                    Random randMonster = new Random();
                    int randNbr = randMonster.Next(waterMonsters.Count);
                    Monster chosenMonster = waterMonsters[randNbr];

                    Console.WriteLine($"You encounter a {chosenMonster.Name.ToLower()}.");
                }

                else if (roomNbr == 2 || roomNbr == 3)
                {
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

                    Random randMonster = new Random();
                    int randNbr = randMonster.Next(dangerousMonsters.Count);
                    Monster chosenMonster = dangerousMonsters[randNbr];

                    if (chosenMonster == wolf3) { Console.WriteLine("You encounter " + chosenMonster.Name.ToLower()); }
                    else { Console.WriteLine($"You encounter a {chosenMonster.Name.ToLower()}"); }
                }

                else if (roomNbr == 5)
                {
                    List<Monster> caveMonsters = new List<Monster>();
                    {
                        caveMonsters.Add(bear1);
                        caveMonsters.Add(bear2);
                        caveMonsters.Add(bear3);
                        caveMonsters.Add(bat1);
                        caveMonsters.Add(bat2);
                        caveMonsters.Add(bat3);
                        caveMonsters.Add(snake1);
                        caveMonsters.Add(snake2);
                        caveMonsters.Add(snake3);

                        Random randMonster = new Random();
                        int randNbr = randMonster.Next(caveMonsters.Count);
                        Monster chosenMonster = caveMonsters[randNbr];

                        Console.WriteLine($"You encounter a {chosenMonster.Name.ToLower()}.");
                    }
                }

                #endregion

                #region Gameplay Menu Loop

                bool reload = false;

                do
                {
                    #region Display the Menu

                    //TODO Display the menu to the user

                    #endregion

                    #region Check Player Life

                    //TODO check player life and kill if <= 0

                    #endregion

                } while (!exit && !reload);

                #endregion

            } while (!exit);

            #endregion

            #region Output Final Score / End the Game

            //TODO show score

            #endregion
        }
    }
}
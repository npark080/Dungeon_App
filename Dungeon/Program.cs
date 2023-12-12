using DungeonLibrary;
using static System.Formats.Asn1.AsnWriter;
using System.Numerics;
using System;
using System.Linq.Expressions;
using System.Threading;
namespace Dungeon
{
    class Program
    {
        private static void Main(string[] args)
        {
            #region Title/Introduction

            Console.WriteLine("The Witch's Forest\n");

            #endregion

            #region Variable to Keep Score

            int killScore = 0;
            int friendScore = 0;

            #endregion

            #region Weapon Object Creation

            Weapon slap = new("Bare Hands", 8, 3, 10, WeaponType.hands);
            Weapon fists = new("Fist", 10, 3, 10, WeaponType.hands);
            Weapon spear = new("Spear", 18, 5, 15, WeaponType.spear);
            Weapon hunterSpear = new("Hunter's Spear", 20, 8, 15, WeaponType.spear);
            Weapon oldAxe = new("Rusty Axe", 20, 5, 20, WeaponType.axe);
            Weapon newAxe = new("Shiny Axe", 25, 10, 20, WeaponType.axe);
            Weapon rock = new("Rock", 10, 5, 15, WeaponType.rock);
            Weapon antler = new("Antler Club", 25, 10, 25, WeaponType.antlers);
            Weapon bone = new("Bone", 15, 4, 15, WeaponType.bone);
            Weapon stick = new("Stick", 12, 3, 15, WeaponType.stick);
            Weapon machete = new("Machete", 30, 15, 20, WeaponType.machete);

            #endregion

            #region Player Object Creation & Customization

            Console.Write("Please enter your name: ");
            string playerName = Console.ReadLine();

            Console.WriteLine("\nWhat are you?\n\n1)Human\n2)Hunter\n3)Sprite\n");
            string playerSelection = Console.ReadLine().ToLower();

            Player player = new(playerName, 50, 50, 50, 50, Race.human, slap);

            switch (playerSelection)
            {
                case "1":
                case "human":
                    Console.WriteLine("Ah, a human...");
                    break;

                case "2":
                case "hunter":
                    player.MaxLife = 60;
                    player.HitChance = 60;
                    player.Block = 60;
                    player.Life = 60;
                    player.CharacterRace = Race.hunter;
                    player.EquippedWeapon = fists;
                    Console.WriteLine("A hunter?  I would never have guessed just looking at you.");
                    break;

                case "3":
                case "sprite":
                    player.MaxLife = 40;
                    player.Block = 40;
                    player.Life = 40;
                    player.CharacterRace = Race.sprite;
                    Console.WriteLine("Oh little creature, what are you doing here?");
                    break;

                default:
                    Console.WriteLine("That doesn't exist...I don't care for people trying to trick me.");
                    break;
            }

            Console.WriteLine("\nPress enter to wake up.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"You find yourself coming to consciousness in a forest clearing.  You vaguely remember running into a lady but nothing after that.  You've heard that a witch has been kidnapping {player.CharacterRace}s recently but you never thought you'd find yourself in this situation.  As you try to orient yourself, you find that you are hazily going from area to area without quite remembering the journey.  You know you're essentially in the witch's pantry along with all her other \"ingredients\".");

            Console.WriteLine("\nPress enter to continue.");
            Console.ReadLine();
            Console.Clear();


            #endregion

            #region Main Game Loop
            bool exit = false;

            do
            {
                #region MonsterObject Creation

                Bee bee1 = new("Worker Bee", 90, 60, 15, 15, 15, 10, "Buzzing for a fight", 0, false);
                Bee bee2 = new("Babee", 80, 50, 10, 10, 12, 8, "A sweetie", 20, true);
                Bee bee3 = new("Queen Bee", 100, 70, 20, 20, 20, 15, "A royal pain in the beehind", 0, false);

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
                Witch witch = new("The Witch", 100, 80, 60, 100, 30, 15, "The illusion should break when she's dead", 0);
                NoOne noOne = new("Nothing", 0, 0, 0, 0, 0, 0, "Looks like no one's here", 0);

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

                List<Monster> cabinMonsters = new List<Monster>();
                cabinMonsters.Add(witch);
                cabinMonsters.Add(noOne);

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
                Console.WriteLine();

                Monster chosenMonster = bee1;

                if (roomNbr == 0 || roomNbr == 8 || roomNbr == 4)
                {
                    Random randMonster = new Random();
                    int randNbr = randMonster.Next(safeMonsters.Count);
                    chosenMonster = safeMonsters[randNbr];

                    Console.WriteLine($"You encounter a {chosenMonster.Name.ToLower()}.");
                }

                else if (roomNbr == 1 || roomNbr == 7)
                {

                    Random randMonster = new Random();
                    int randNbr = randMonster.Next(waterMonsters.Count);
                    chosenMonster = waterMonsters[randNbr];

                    Console.WriteLine($"You encounter a {chosenMonster.Name.ToLower()}.");
                }

                else if (roomNbr == 2 || roomNbr == 3)
                {

                    Random randMonster = new Random();
                    int randNbr = randMonster.Next(dangerousMonsters.Count);
                    chosenMonster = dangerousMonsters[randNbr];

                    if (chosenMonster == wolf3) { Console.WriteLine("You encounter " + chosenMonster.Name.ToLower()); }
                    else { Console.WriteLine($"You encounter a {chosenMonster.Name.ToLower()}."); }
                }

                else if (roomNbr == 5)
                {

                    Random randMonster = new Random();
                    int randNbr = randMonster.Next(caveMonsters.Count);
                    chosenMonster = caveMonsters[randNbr];

                    Console.WriteLine($"You encounter a {chosenMonster.Name.ToLower()}.");

                }

                else
                {
                    Random randMonster = new Random();
                    int randNbr = randMonster.Next(cabinMonsters.Count);
                    chosenMonster = cabinMonsters[randNbr];

                    Console.WriteLine($"You encounter {(chosenMonster == witch ? "the" : "")} {chosenMonster.Name.ToLower()}.");
                }

                #endregion

                #region Item Creation
                List<Item> inventory = new();
                Item mouse = new("Mouse");
                Item insects = new("Insect");
                Item acorn = new("Acorn");
                Item fruit = new("Fruit");
                Item flowers = new("Bouquet");
                Item honey = new("Honey");

                #endregion

                #region Gameplay Menu Loop

                bool reload = false;

                do
                {

                    #region Display the Menu

                    Console.WriteLine("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "T) Talk\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "I) Inventory\n" +
                        "X) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;

                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:

                            if (chosenMonster == bee1 || chosenMonster == bee2 || chosenMonster == bee3)
                            {
                                Combat.DoBattleBee(player, chosenMonster);
                                if (chosenMonster.Life <= 0)
                                {
                                    killScore++;
                                    reload = true;
                                }
                            }
                            else
                            {
                                Combat.DoBattle(player, chosenMonster);

                                if (chosenMonster.Life <= 0 && chosenMonster == witch)
                                {
                                    Console.WriteLine("You finally killed her.  The forest starts dissipating and you find yourself back in your home.");
                                    exit = true;
                                }

                                if (chosenMonster.Life <= 0)
                                {
                                    Console.WriteLine("\nYou killed the {0}.\n", chosenMonster.Name.ToLower());
                                    Console.WriteLine($"You can't let its carcass go to waste.  You decide to cook and eat the {chosenMonster.Name.ToLower()}.");
                                    if (Frog.Poisonous || Snake.Poisonous)
                                    {
                                        player.Life -= 5;
                                    }
                                    else
                                    {
                                        player.Life += 15;
                                    }

                                    killScore++;
                                    reload = true;
                                }
                            }
                            break;

                        case ConsoleKey.T:
                            if (chosenMonster == witch)
                            {
                                Console.WriteLine($"The witch cackles.  She finds it hilarious how it never gets old seeing her food beg.\n" +
                                    $"Talking to her is useless.");
                            }

                            else if (chosenMonster == bee1 || chosenMonster == bee2 || chosenMonster == bee3)
                            {
                                Talk.TalkBee(player, chosenMonster);
                                if (chosenMonster.Affection >= 100)
                                {
                                    friendScore++;
                                    reload = true;
                                }
                            }

                            else
                            {
                                Talk.DoTalk(player, chosenMonster);
                                if (chosenMonster.Affection >= 100)
                                {
                                    Console.WriteLine($"You brought up some good points.  The {chosenMonster.Name.ToLower()} feels bad for hurting you so they bring you some sustenance.");
                                    player.Life += 20;
                                    friendScore++;
                                    reload = true;
                                }
                            }

                            break;
                        case ConsoleKey.R:

                            Console.WriteLine("You choose to run away.");
                            Console.WriteLine($"{chosenMonster.Name} attacks you as you flee.");
                            Combat.DoAttack(chosenMonster, player);
                            Console.WriteLine();
                            reload = true;
                            break;

                        case ConsoleKey.P:
                            Console.WriteLine(player);
                            break;

                        case ConsoleKey.M:
                            Console.WriteLine(chosenMonster);
                            break;

                        case ConsoleKey.I:

                        //TODO add inventory

                        case ConsoleKey.X:
                            Console.WriteLine("No one likes a quitter...");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Input not recognized.  Please try again.");
                            break;
                    }
                    #region Check Player Life

                    if (player.Life <= 0)
                    {
                        Console.WriteLine("You have been vanquished.");

                        exit = true;
                    }

                    #endregion

                } while (!exit && !reload);

                #endregion
                #endregion

                #region Output Final Score / End the Game

                Console.WriteLine($"\nYou've killed {killScore} creatures.\n");
                Console.WriteLine($"You've befriended {friendScore} creatures.\n");

                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                Console.Clear();

                #endregion
                #endregion
            } while (!exit);
        }
    }
}
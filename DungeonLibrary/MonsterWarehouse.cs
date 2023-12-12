using System;

namespace DungeonLibrary
{
    public class MonsterWarehouse
    {
        public static void GetMonster()
        {
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
        }
    }
}

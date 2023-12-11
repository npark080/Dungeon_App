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
            string[] rooms =
{
                    "You step into a forest clearing... it looks oddly like the place you woke up in.",
                    "You come across a babbling brook, just small enough to be quaint but just large enough you can't cross.",
                    "You reach the base of a mountain.  It seemed farther away than it is.",
                    "You struggle through dense woods.",
                    "Oh how nice, a mushroom grove.  You wish you paid more attention to herbology and don't dare risk eating a mushroom.",
                    "You wander into a cave.  You can almost feel pressure in the atmosphere.",
                    "You bravely stepped foot in a cabin, the walls are lined with books and potions.  You definitely don't want to be here.",
                    "You stumble upon a lake.  Its serene disposition feels as if it's taunting your grave circumstances.",
                    "You find yourself in the midst of a flower field.  How strange, they're all your favorite colors."
            };
            Random rng = new Random();
            int roomNbr = rng.Next(rooms.Length);
            Console.WriteLine(rooms[roomNbr]);
        }
    }
}
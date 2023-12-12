using Microsoft.VisualBasic;
using DungeonLibrary;

namespace Testing
{
    public class UnitTests
    {
        #region Calculator Tests
        [Fact]
        public void Test_DoBattleBee()
        {
            //ARRANGE
            Item i = new("item");

            string expected = "item";

            //ACT
            string actual = i.ToString();

            //ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TalkBee()
        {
            //ARRANGE
            Bee bee = new("Worker Bee", 90, 60, 15, 15, 15, 10, "Buzzing for a fight", 0, false);

            int expected = 0; 

            //ACT
            int actual = bee.Affection;

            //ASSERT
            Assert.Equal(expected, actual);
        }
        #endregion
    }
}
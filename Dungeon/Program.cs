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

                //TODO Create monsters

                #endregion

                #region Room Creation

                //TODO create rooms

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
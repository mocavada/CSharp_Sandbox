using System;

namespace DependecyInjection_JavaGames
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Computer com = new Computer(new LOL());
            com.playGame();

            Computer com2 = new Computer();
            com2.setGame(new SC2());
            com2.playGame();


        }
    }
}

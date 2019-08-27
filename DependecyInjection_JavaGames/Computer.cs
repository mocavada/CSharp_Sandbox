using System;
namespace DependecyInjection_JavaGames
{
    public class Computer
    {

        public Games game;

        public Computer()
        {

        }
        // Constructor Injection
        public Computer(Games game)
        {
            this.game = game;
        }


        // Method / Setter Injection
        public void setGame(Games game)
        {
            this.game = game;
        }

        public void playGame()
        {
            if(game != null)
            {
                game.Play();
            }
        }
    }
}

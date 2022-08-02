using System;

namespace Player
{
    class Program
    {
        static void Main(string[] args)
        {
            Player sue = new Player(100, "Sue", "Smith");
            Player tom = new Player(200, "Tom", "West");
           
            //???sue.NumberofVictories = 3;
            //???sue.NumberofLooses = 2;

            sue.ScoreGameWin();
            sue.ScoreGameWin();
            sue.ScoreGameWin();
            sue.ScoreGameLooses();
            sue.ScoreGameLooses();
            
            sue.Info();
            Console.WriteLine(sue);
            Console.WriteLine(tom);

        }
    }
}

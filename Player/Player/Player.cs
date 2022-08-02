using System;
using System.Collections.Generic;
using System.Text;

namespace Player
{
    class Player
    {
        //Declare the member veriables for the Player class.
        
        private int numberofVictories;
        private int numberofLooses;
        private int numberofGames;
        private int playerID;
        private string firstName;
        private string lastName;




        //Define the constructors sturting with the default.
        Player()
        { 
        }
        //Define a constractor for Player with parameter values.
        public Player(int paramID, string paramName, string paramLastName)
        {
            playerID = paramID;
            firstName = paramName;
            lastName = paramLastName;

        }

        //Define properties.
        public int NumberofGames
        {
            get
            {
                return numberofGames;
            }

        }

        public int NumberofVictories
        {
            get
            {
                return numberofVictories;
            }
            
        }

        public int NumberofLooses
        {
            get
            {
                return numberofLooses;
            }
           
        }



        //Define the istance methods.

        public void ScoreGameWin()
        {
            numberofVictories++;
            numberofGames++;
        }
        public void ScoreGameLooses()
        {
            numberofLooses++;
            numberofGames++;
        }



        private float CalWinPercent()
        {
            float winPercent = (numberofGames == 0) ? winPercent = 0.0f : winPercent = (NumberofVictories * 100) / numberofGames;

            return winPercent;
        }



        public void Info()
        {
            Console.WriteLine($"Player Sue won {NumberofVictories} games and lost {NumberofLooses} games");
        }
        public override string ToString()
        {
            return 
                
                "PlayerID: " + playerID +
                ", name: " + firstName + " " + lastName +
                ", games played: " + numberofGames +
                ", win percent: " + CalWinPercent() + "%";

        }
        
    }
}

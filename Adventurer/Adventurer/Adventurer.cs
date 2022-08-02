using System;
using System.Collections.Generic;
using System.Text;

namespace Adventurer
{
    class Adventurer
    {
        //attributes:
        private string givenName;
        private int healthPoints;
        private int age;
        private bool superStrenth;
        private float weight;
        private decimal height;
        

        //properties
        Adventurer()
        { 
        }
        //parameter values
        public Adventurer(string paramGivenName, int paramHealthPoints, int paramAge, bool paramSuperStrenth, 
            float paramWeight, decimal paramHeight)
        {
            givenName = paramGivenName;
            healthPoints = paramHealthPoints;
            age = paramAge;
            superStrenth = paramSuperStrenth;
            weight = paramWeight;
            height = paramHeight;

         }
        //set up mutators

        


        public string GivenName
        {
            get
            {
                return givenName;
            }
            set 
            {
                givenName = value;
            }

        }
        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                healthPoints = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            
        }

        public bool SuperStrenth
        {
            get
            {
                return superStrenth;
            }
            set
            {
                superStrenth = value;
            }

        }
        public float Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public decimal Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }

        }

      
        
        //instance method
        private int CalPetAge()
        {
            
            int petAge= age -10;
            return petAge;
            

        }


        public override string ToString()
        {
            return

                "Character's pet age: " + CalPetAge();
            //for some reason it doesn't show the right result for CalPetAge() method
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dragon
{
    class Dragon
    {
        private string dragonName;
        private int dragonAge;
        private float flighSpeedKPH;
        private bool breathFire;
        private string dragonColour;
        private string dragonHobby;


        public Dragon()
        {
        }
        public Dragon(string paramName)
        {
            dragonName = paramName;
        }
        public Dragon(string paramName, int paramAge, float paramSpeed, bool paramBreath)
        {
            dragonName = paramName;
            dragonAge = paramAge;
            flighSpeedKPH = paramSpeed;
            breathFire = paramBreath;
        }
        public bool BreathFire
        {
            get
            {
                return breathFire;
            }

        }
        public float FlightSpeed
        {
            get
            {
                return flighSpeedKPH;
            }

        }
        public int DragonAge
        {
            get
            {
                return dragonAge;
            }

        }
        public string DragonColour
        {
            get
            {
                return dragonColour;
            }
            set
            {
                dragonColour = value;
            }

        }
        public string DragonHobby
        {
            get
            {
                return dragonHobby;
            }
            set
            {
                dragonHobby = value;
            }

        }

      
        public override string ToString()
        {
            return "Dragon Name: " + dragonName +
            ", \nage: " + dragonAge +
            ", \nspeed: " + flighSpeedKPH + " hph" +
            ", \nbreath fire: " + breathFire +
            ", \ncolor: " + dragonColour +
            ", \nhobby: " + dragonHobby + ".";
        }
    }
}

    
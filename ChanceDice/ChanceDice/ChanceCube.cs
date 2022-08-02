using System;
using System.Collections.Generic;
using System.Text;

namespace ChanceDice
{

    class ChanceCube
    {
        //Declare the member veriables for the ChanceCube class.
        const int MAX_SIDES = 6;
        private int faceValue;
        private Random n;


        //Define the constructors sturting with the default.
        public ChanceCube()
        {
            faceValue = 1;
            n = new Random();
        }
        //Define the instance method.
        public int RollCube()
        {
            faceValue = n.Next(1, MAX_SIDES + 1);
            return faceValue;
        }
        public override string ToString()
        {
            return "Up: " + faceValue;
        }

    }
}

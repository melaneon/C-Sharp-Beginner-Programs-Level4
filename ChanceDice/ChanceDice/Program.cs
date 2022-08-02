using System;

namespace ChanceDice
{
    class Program
    {
        static void Main(string[] args)
        {
            ChanceCube redCube = new ChanceCube();
            redCube.RollCube();
            Console.WriteLine(redCube);
            Console.ReadKey();

        }
    }
}

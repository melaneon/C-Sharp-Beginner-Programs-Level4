using System;
using System.Xml.Schema;

namespace Dragon
{
    class Program
    {
        static void Main(string[] args)
        {
            Dragon martinTheDragon = new Dragon("Martin", 32, 75.20f, true);
            martinTheDragon.DragonColour = "red";
            martinTheDragon.DragonHobby = "ruining the villages";

            Console.WriteLine(martinTheDragon);
            Console.ReadKey();
        }
    }
}

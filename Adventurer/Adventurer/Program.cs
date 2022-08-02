using System;

namespace Adventurer
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            
            Console.WriteLine("{0,20}","Please enter the following data");
            Adventurer obj = new Adventurer(GetaName(), GetHealthPoints(), GetAge(), GetSuperStrenth(), GetWeight(), GetHeight());

            static string GetaName()
            {
                Console.Write("Character's name: ");
                string givenName = Console.ReadLine();
                return givenName;
            }
            static int GetHealthPoints()
            {
                Console.Write("HealthPoint(1-100): ");
                int healthPoints = int.Parse(Console.ReadLine());
                return healthPoints;
            }
            static int GetAge()
            {
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                return age;
            }
            static bool GetSuperStrenth()
            {
                Console.Write("Ability to fly(true/false) ");
                bool superStrenth = bool.Parse(Console.ReadLine());
                return superStrenth;
            }
            static float GetWeight()
            {
                Console.Write("Weight(in kg): ");
                float weight = float.Parse(Console.ReadLine());
                return weight;
            }
            static decimal GetHeight()
            {
                Console.Write("Height(in meters): ");
                decimal height = decimal.Parse(Console.ReadLine());
                return height;
            }

            Console.Clear();


            Console.WriteLine(obj);
            
            Console.ReadKey();

        }
    }
}

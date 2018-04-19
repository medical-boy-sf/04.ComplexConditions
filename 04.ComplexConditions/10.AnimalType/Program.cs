using System;
namespace _10.AnimalType
{
    class Program
    {
        static void Main()
        {
            string animal = Console.ReadLine();
            string typeAnimal = "";

            switch (animal)
            {
                case "dog":
                    typeAnimal = "mammal";
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    typeAnimal = "reptile";
                    break;
                default:
                    typeAnimal = "unknown";
                    break;
            }

            Console.WriteLine(typeAnimal);
        }
    }
}

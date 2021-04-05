using System;
using System.Collections.Generic;

namespace ZooProject
{
    class Program
    {
        interface IAnimal
        {
            int Age { set; get; }
            string Species { get; }
            void RequestUniqueCharacteristic();
            string GetDescription();
        }

        public class Lion : IAnimal

        {
            private string _maneColour;
            public int Age { get; set; }
            public string Species { get => "Lion"; }

            public string GetDescription()
            {
                return Age + "-year-old " + Species + " with a " + _maneColour + " mane";
            }

            public void RequestUniqueCharacteristic()
            {
                Console.Write("What colour is its mane? ");
                _maneColour = Console.ReadLine();
            }

        }
        public class Wolf : IAnimal

        {
            private String speed;
            public int Age { get; set; }
            public string Species { get => "Wolf"; }

            public string GetDescription()
            {
                return Age + "-years-old " + Species + " That runs " + speed +"KM/h";
            }

            public void RequestUniqueCharacteristic()
            {
                Console.Write("How fast can it run(in KM/h)");
                speed = Console.ReadLine();
            }
        }
        public class Bear : IAnimal

        {
            private bool IsGrizzly;
            public int Age { get; set; }
            public string Species { get => "Bear"; }

            public string GetDescription()
            {
                return Age + "-years-old " + (IsGrizzly ? "" : "non-") + "Grizzly Bear ";
                 
            }
            public void RequestUniqueCharacteristic()
            {
                Console.Write("Is it a grizzly bear(true/false)");
                IsGrizzly = Console.ReadLine().ToLower() == "yes";
            }

        }



        static void Main(string[] args)
        {
            int totalAnimals = 3;

            List<IAnimal> animals = new List<IAnimal>();
            IAnimal newAnimal = null;
            for (int i = 0; i < totalAnimals; i++)
            {
                Console.WriteLine("Cage " + i);
                Console.WriteLine("");
                Console.Write("What is the animal's species? ");
                String animal = Console.ReadLine();
                
                switch (animal)
                {
                    case "lion":
                        newAnimal = new Lion();
                        break;
                    case "bear":
                        newAnimal = new Bear();
                        break;
                    case "wolf":
                        newAnimal = new Wolf();
                        break;
                }
                Console.Write("How old is it? ");
                newAnimal.Age = Convert.ToInt32(Console.ReadLine());
                newAnimal.RequestUniqueCharacteristic();
                animals.Add(newAnimal);
            }
            Console.WriteLine("\n................\n");
                foreach (var animal in animals)
                {
                int ind = animals.IndexOf(animal);
                Console.Write("Cage " + (ind + 1) + " contains a ");
                Console.WriteLine(animal.GetDescription());
                }

            
        }
    }
}

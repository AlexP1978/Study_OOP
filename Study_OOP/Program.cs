using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_OOP
{
    class Program
    {
        public class Animal
        {
            public string name;
            public string breed;
            public int years;
            public double weight;
            public string voice;
            protected string color;

            public Animal() { }
            public Animal(string name,int years,double weight) { }
            public Animal(string name, string breed, int years, double weight, string voice)
            {
                this.name = name;
                this.breed = breed;
                this.years = years;
                this.weight = weight;
                this.voice = voice;
            }

            /// <summary>
            /// voice of animal
            /// </summary>
            public virtual void Voice()
            {
            }
            /// <summary>
            /// picture of animal
            /// </summary>
            public virtual void Picture()
            {

            }

        }


        public class Dog : Animal
        {
            public string colorDog;
            public Dog() { }
            public Dog(string name, string breed, int years, double weight, string voice) 
                : base(name,breed,years,weight,voice)
            {
                this.color = "white";
            }

            /// <summary>
            /// voice of dog
            /// </summary>
            public override void Voice()
            {
                Console.WriteLine($"Dog say - {voice}");
            }
            /// <summary>
            /// return color of dog
            /// </summary>
            /// <returns></returns>
            public string Color()
            {
                colorDog = color;
                return colorDog;
            }
            /// <summary>
            /// picture of dog
            /// </summary>
            public override void Picture()
            {
                Console.WriteLine("___   ___");
                Console.WriteLine("|  |__|  |");
                Console.WriteLine("|        |");
                Console.WriteLine("|  @  @  |");
                Console.WriteLine("|   ||   |");
                Console.WriteLine("|  ____  |");
                Console.WriteLine("|________|");
            }

            public string this[string nameofDog]
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
                    
            }


        }

        public class Cat : Animal
        {
            public string colorCat;
            Animal[] data;
            public Cat()
            {
                data = new Animal[3];
            }

            public Animal this[int idx]
            {
                get
                {
                    return data[idx];
                }

                set
                {
                    data[idx] = value;
                }

            }



            public Cat(string name, string breed, int years, double weight, string voice) 
                : base(name,breed,years,weight,voice)
            {
                color = "brown";
            }
            /// <summary>
            /// voice of cat
            /// </summary>
            public override void Voice()
            {
                Console.WriteLine($"Cat say - {voice}");
            }
            /// <summary>
            /// return color of cat
            /// </summary>
            /// <returns></returns>
            public string Color()
            {
                colorCat = color;
                return colorCat;
            }
            /// <summary>
            /// picture of cat
            /// </summary>
            public override void Picture()
            {
                Console.WriteLine("___   ___");
                Console.WriteLine("|  |__|  |");
                Console.WriteLine("|        |");
                Console.WriteLine("|  @  @  |");
                Console.WriteLine("|   ||   |");
                Console.WriteLine("|  ____  |");
                Console.WriteLine("|____|___|");
            }
        }
        static void Main(string[] args)
        {
            //Animal animal = new Dog("Juchka", "Taksa", 5, 10.2, "Gav-Gav");

            Dog dog = new Dog("Juchka", "Taksa", 5, 10.2, "Gav-Gav");
            Cat cat = new Cat("Murka", "Home", 2, 4.3, "Myau-Myau");



            //animal.Voice();
            cat.Voice();
            dog.Voice();
            cat.Color();
            dog.Color();

            Console.WriteLine($"{dog.name} is {dog.colorDog} color and foto of dog");
            dog.Picture();
            Console.WriteLine($"{cat.name} is {cat.colorCat} color and foto of cat");
            cat.Picture();

            Dog dog1 = new Dog();
            dog1["name"] = "Sharik";
            Console.WriteLine($"\n{dog1["name"]}\n");


            Cat cat1 = new Cat();

            cat1[0] = new Animal { name = "Murchik" };
            cat1[1] = new Animal { name = "Rugik" };
            cat1[2] = new Animal { name = "Matroskin"};

            for (int i = 0; i < 3; i++)
                Console.WriteLine($"{ cat1[i].name}");

            Animal animal = dog1;
            animal.name = "Sirko";
            Dog dog2 = (Dog)animal;
            Console.WriteLine($"\nThe name of dog is {dog2.name}");

            Console.Read();

        }
    }
}

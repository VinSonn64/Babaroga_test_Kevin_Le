using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> FarmHouse = new List<Animal>(); //FarmHouse has a List of Animals

            Chicken chicken1 = new Chicken("Moe", "Cluck", true, 10, 3);
            Cow cow1 = new Cow("Curly", "Moo", true, 200, 7);
            Pig pig1 = new Pig("Larry", "Cluck", true, 120, 5);
            Dog dog1 = new Dog();

            FarmHouse.Add(chicken1);
            FarmHouse.Add(cow1);
            FarmHouse.Add(pig1);

            for (int i = 0; i < FarmHouse.Count(); i++)
            {
                FarmHouse[i].DisplayInfo();
                FarmHouse[i].Speak();

            }

            Console.Read();
        }
    }

    class Animal //Generic Animal class
    {
        //Basic shared members of farm animals
        public string name, sound;
        public bool isMale;
        public double weight, age;


       public Animal() //constructor
        {
            name = "emptyName";
            sound = "noSound";
            isMale = true;
            weight = 10;
            age = 1;
        }

       public Animal(string _name, string _sound, bool _isMale, double _weight, double _age) //constructor
        {
            name = _name;
            sound = _sound;
            isMale = _isMale;
            weight = _weight;
            age = _age;
        }

        public virtual void DisplayInfo() //virtual function display info
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Age: " + age);
            Console.WriteLine();
        }

        public void Speak() //Each Animal makes a sound
        {
            Console.WriteLine(sound);
            Console.WriteLine();
        }

    }

    class Chicken : Animal //Inheritance
    {
        int eggsLaid;

        public Chicken(string _name, string _sound, bool _isMale, double _weight, double _age) : base()
        {
            name = _name;
            sound = _sound;
            isMale = _isMale;
            weight = _weight;
            age = _age;
            eggsLaid = 0;
        }


        public void LayEgg()
        {
            if (isMale)
            {
                Console.WriteLine("I can't lay eggs.");
            }

            eggsLaid++;
            Console.WriteLine("I laid an egg.");
        }

        public override void DisplayInfo() //override display function, plus eggs laid
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Eggs Laid: " + eggsLaid);
            Console.WriteLine();
        }
    }


    //Other Animals
    class Cow : Animal
    {
        public Cow(string _name, string _sound, bool _isMale, double _weight, double _age) : base()
        {
            name = _name;
            sound = _sound;
            isMale = _isMale;
            weight = _weight;
            age = _age;
        }
    }

    class Pig: Animal
    {
        public Pig(string _name, string _sound, bool _isMale, double _weight, double _age) : base()
        {
            name = _name;
            sound = _sound;
            isMale = _isMale;
            weight = _weight;
            age = _age;
        }
    }

    class Sheep : Animal { }

    class Horse : Animal { }

    class Dog : Animal { }
}

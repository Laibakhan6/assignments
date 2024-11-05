using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Human
    {
        public string name;
        public string age;
        public string gender;
        public string contact;
        public void Run()
        {
            Console.WriteLine("my name is "+name+ "......");
        }


    }

    class Animals
    {
        public string name;
        public string age;
        public string food;

        public void Start()
        {
            Console.WriteLine(name);
        }
            }
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.name = "laiba ";
            human.age = "20";
            human.gender = "fmale";
            human.contact = "12345";
            human.Run();

            
            Animals animals = new Animals();
            animals.name = "donkey";
            animals.age = "1";
            animals.food = "grass ";

            animals.Start();

            Console.ReadKey();

        }
    }
}

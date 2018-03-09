using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person(5);
            per.GrowUp();
            per.Say();
            Console.WriteLine("Hello World!");

        }
    }
    class Person
    {
        public Person(int a)
        {
            this.age = a;
        }
        int age;
        public void GrowUp()
        {
            this.age++;
        }

        public void Say()
        {
            Console.WriteLine("my age is {0}",this.age);
        }
    }
}
 
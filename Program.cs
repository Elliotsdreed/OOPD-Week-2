using System;

namespace OOPD_Week_2
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Creating an instance of Parent");
        }

        public void Print()
        {
            Console.WriteLine("I am a Parent");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("Creating an instance of Child");
        }

        public void Print()
        {
            Console.WriteLine("I am a Child");
        }
        public void SayGoodbye()
        {
            Console.WriteLine("Bye");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ParentClass parent = new ParentClass();
            ChildClass child = new ChildClass();

            child.SayHello();
        }
    }
}

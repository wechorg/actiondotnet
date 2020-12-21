using System;

namespace actiondotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Paul","Wechuli");
            Console.WriteLine($"{p.FirstName},{p.LastName}");
        }
    }

    class Person{
        public string FirstName{get;set;}
        public string LastName{get;set;}

        public Person(string firstName,string lastName){
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}

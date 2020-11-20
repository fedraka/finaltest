using System;

namespace finaltest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person[] Persons = new Person[] { new Adult(), new Child() };
            foreach (Person p in Persons)
            {
                p.WriteFullName();
            }
        }

        public class Person
        {
            public string FirstName { set; get; }
            public string LastName { set; get; }

            //Person(string first ,string last)
            //{
            //    FirstName = first;
            //    LastName = last;
            //}
            public virtual void WriteFullName()
            {
                Console.WriteLine("Nothing");
            }
        }
            public class Adult: Person
        {
            public override void WriteFullName()
            {
                Console.WriteLine("Adult name is : Susi Adem");
            }
        }

        public class Child :Person
        {
            public override void WriteFullName()
            {
                Console.WriteLine("Child name is : Asha Leo");
            }
        }
    }
}

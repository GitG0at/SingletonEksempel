using System;

namespace SingletonEksempel
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Poul", 34);
            Person p2 = new Person("Kurt", 45);
            PresidentTheOneAndOnly pr = PresidentTheOneAndOnly.Instance;
            pr.Name = "Trump";
            pr.Party = "Rep";


            //Andet sted i programmet


            PresidentTheOneAndOnly pr2=PresidentTheOneAndOnly.Instance;
            pr2.Name = "Biden";
            pr2.Party = "Dem";


            Console.WriteLine($"Navn på president i pr{ pr.Name }");
            Console.WriteLine($"Navn på president i pr2{ pr2.Name }");

            PersonCatalog per = PersonCatalog.Instance;

            Console.WriteLine("Hello World!");
        }
    }
}

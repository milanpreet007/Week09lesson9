using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            pet pet1 = new pet("sultan", 4, "dog");
            Console.WriteLine(pet1);
            pet1.SetOwner("john");
            Console.WriteLine(pet1);
            pet pet2 = new pet("rocky", 5, "dog");
            pet2.Train();
            Console.WriteLine(pet2);
            pet pet3 = new pet("mental", 9, "cat");
            pet pet4 = new pet("buzo", 4, "dog");
        }
    }
}

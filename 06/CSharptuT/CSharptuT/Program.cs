using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharptuT
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();

            cat.SetName("Whiskers");
            cat.Sound = "Meow";
            Console.WriteLine("The cat is named {0} and says {1}", cat.GetName(), cat.Sound);

            cat.Owner = "Jason";
            Console.WriteLine("{0} owner is {1}", cat.GetName(), cat.Owner);


            Console.WriteLine("{0} shelter is {1}", cat.GetName(), cat.idNum);

            Animal fox = new Animal("Oscar", "Rawrrrr");

            Console.WriteLine("# of Animals : {0}", Animal.NumOfAnimals);

            Console.ReadLine();
        }
    }
}

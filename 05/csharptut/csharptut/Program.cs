using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptut
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea("rectangle", 5, 6));

            int? randNum = null;

            if (randNum == null)
            {
                Console.WriteLine("randNum is null");
            }

            if (!randNum.HasValue)
            {
                Console.WriteLine("randNum is null");
            }

            Console.ReadLine();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dimevtora
{
    class Program
    {
        static string[] sheep = new string[6];
        static int present = 0, notpresent = 0, unknown = 0;
        
        static void counter()
        {
            foreach(string sh in sheep)
            {
                if (sh == "true")
                    present++;
                else if (sh == "false")
                    notpresent++;
                else
                    unknown++;
            }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 6; i++)
                sheep[i] = Console.ReadLine();
            counter();
            Console.WriteLine("{0} sheep are present", present);
            Console.WriteLine("{0} sheep are absent", notpresent);
            Console.WriteLine("{0} sheep presence unknown", unknown);
            Console.ReadKey();
        }
    }
}

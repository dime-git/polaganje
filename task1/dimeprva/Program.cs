using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dimeprva
{
    class Program
    {
        static int[] ages = new int[8];
        static int oldest = ages[0];
        static int youngest = ages[0];
        static void findOldest()
        {
            for(int i = 1; i < 8; i++)
            {
                if (ages[i] > oldest)
                    oldest = ages[i];
            }
            Console.WriteLine("Oldest student is " + oldest + " years old.");
        }

        static void findYoungest()
        {
            int youngest = ages[0];
            for(int i = 1; i < 8; i++)
            {
                if (ages[i] < youngest)
                    youngest = ages[i];
            }
            Console.WriteLine("Youngest student is " + youngest + " years old.");
        }

        static void counter()
        {
            Dictionary<int,int> dictionary = new Dictionary<int, int>();
            foreach(int age in ages)
            {
                dictionary.TryGetValue(age, out int count);
                dictionary[age] = count + 1;
            }
            foreach(var pair in dictionary)
            {
                if((pair.Value == 1 && pair.Key == youngest) || (pair.Value == 1 && pair.Key == oldest)){
                    Console.WriteLine(pair.Key);
                }
                else if(pair.Value > 1)
                {
                    Console.WriteLine("There are {0} students aged {1}", pair.Value, pair.Key);
                }
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter elements in the array: ");
                for (int i = 0; i < 8; i++)
                {
                    ages[i] = Convert.ToInt32(Console.ReadLine());
                }
                findOldest();
                findYoungest();
                counter();
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

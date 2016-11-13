using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trump
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vill du höra vad jag tycker om valet? (svara ja)");

            string start = "Man känner sig nästan lite känslomässigt avtru";
            string pun = "MP";
            string nopun = "bb";
            string end = "ad";


            if (Console.ReadLine().ToLower() == "ja")
            {
                Console.WriteLine("\n" + start + nopun + end + "\n" + "-----------------------\n");
            }

            Console.WriteLine("\nVill du höra något kul? (svara ja)");

            if (Console.ReadLine().ToLower() == "ja")
            {
                Console.WriteLine("\n" + start + pun + end);
            }

            Console.ReadLine();
            Console.Clear();
            Main(args);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCG.ConsoleUtilities
{
    public class UserInput
    {
        public int GetIntFromUSer(string prompt)
        {
            string input;
            int outrput;

            while (true)
            {
                Console.Write(prompt)
                input = Console.ReadLine();

                if (int.TryParse(input, out output))
                    return Outputter;

                Console.Write("That was not a valid integer... press any key to continue");
                Console.ReadKey();
            }
        }
    }
}
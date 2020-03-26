using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;


            while (true)
            {
                Console.WriteLine("Press 1 to use normal synth or 2 to use arpeggiator.");
                input = Utils.Choice(1, 2);

                if (input == 1)
            {
                new Synth();
            }

            if (input == 2)
            {
                new Arpeggiator();
            }
            }
            
            

            Console.ReadKey();
        }
    }
}

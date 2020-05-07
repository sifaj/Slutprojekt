using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            Arpeggiator A = new Arpeggiator();
            Synth S = new Synth();
            new Sound();

            while (true)
            {
                Console.WriteLine("Press 1 to use normal synth or 2 to use arpeggiator.\nPress 'Q' to quit the current selection.");
                input = Utils.Choice(1, 2);

                if (input == 1)
            {
                    S.PlaySynth();
            }

            if (input == 2)
            {
                    A.PlayArpeggiator();
            }
        }            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt
{
    class Synth : Sound
    {

        public void PlaySynth()
        {
            
            Console.WriteLine("Press any of the following keys to play a note: C-D-E-F-G-A-B");

            while (check == true) // En loop som körs, och som väntar på att spelaren trycka en av knapparna som kan ses ovan, eller Q. 
            {
                if (Console.KeyAvailable) // Ett exempel på ovanstående kommentar, där if satserna kollar ifall spelaren trycker på följande knapp, vilket isåfall skapar korrespånderande not-klass.
                    if (Console.ReadKey(true).Key == ConsoleKey.A)
                    {
                        noteDict["A"].Play();
                    }

                if (Console.KeyAvailable)
                    if (Console.ReadKey(true).Key == ConsoleKey.B)
                    {
                        noteDict["B"].Play();
                    }

                if (Console.KeyAvailable)
                    if (Console.ReadKey(true).Key == ConsoleKey.C)
                    {
                        noteDict["C"].Play();
                    }

                if (Console.KeyAvailable)
                    if (Console.ReadKey(true).Key == ConsoleKey.D)
                    {
                        noteDict["D"].Play();
                    }

                if (Console.KeyAvailable)
                    if (Console.ReadKey(true).Key == ConsoleKey.E)
                    {
                        noteDict["E"].Play();
                    }

                if (Console.KeyAvailable)
                    if (Console.ReadKey(true).Key == ConsoleKey.F)
                    {
                        noteDict["F"].Play();
                    }

                if (Console.KeyAvailable)
                    if (Console.ReadKey(true).Key == ConsoleKey.G)
                    {
                        noteDict["G"].Play();
                    }

                if (Console.KeyAvailable) // Ifall spelaren trycker på Q clearas skärmen och loopen slutar köras. 
                    if (Console.ReadKey(true).Key == ConsoleKey.Q)
                    {
                        Console.Clear();
                        check = false;

                    }

            }
        }

    }
}

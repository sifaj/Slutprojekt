using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt
{
    class Synth : Sound
    {

        public Synth()
        {
            
            Console.WriteLine("Press any of the following keys to play a note: C-D-E-F-G-A-B");

            while (check == true) // En loop som körs, och som väntar på att spelaren trycka en av knapparna som kan ses ovan, eller Q. 
            {
                if (Console.KeyAvailable) // Ett exempel på ovanstående kommentar, där if satserna kollar ifall spelaren trycker på följande knapp, vilket isåfall skapar korrespånderande not-klass.
                    if (Console.ReadKey(true).Key == ConsoleKey.A)
                    {
                        new A_note();
                    }

                if (Console.KeyAvailable)
                    if (Console.ReadKey(true).Key == ConsoleKey.B)
                    {
                        new B_note();
                    }

                if (Console.KeyAvailable)
                    if (Console.ReadKey(true).Key == ConsoleKey.C)
                    {
                        new C_note();
                    }

                if (Console.KeyAvailable)
                    if (Console.ReadKey(true).Key == ConsoleKey.D)
                    {
                        new D_note();
                    }

                if (Console.KeyAvailable)
                    if (Console.ReadKey(true).Key == ConsoleKey.E)
                    {
                        new E_note();
                    }

                if (Console.KeyAvailable)
                    if (Console.ReadKey(true).Key == ConsoleKey.F)
                    {
                        new F_note();
                    }

                if (Console.KeyAvailable)
                    if (Console.ReadKey(true).Key == ConsoleKey.G)
                    {
                        new G_note();
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

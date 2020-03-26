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
            bool check = true;
            Console.WriteLine("Press any of the following keys to play a note: C-D-E-F-G-A-B\nPress 'Q' to exit.");

            while (check == true)
            {
                if (Console.KeyAvailable)
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

                if (Console.KeyAvailable)
                    if (Console.ReadKey(true).Key == ConsoleKey.Q)
                    {
                        check = false;
                    }

            }
        }

    }
}

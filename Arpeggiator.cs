using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt
{
    class Arpeggiator : Sound
    {
       List<string> noteList = new List<string>();

        public Arpeggiator()
        {

        
        Console.WriteLine("How many notes?");
        int notenumber;

        int.TryParse(Console.ReadLine(), out notenumber);

            for (int i = 0; i<notenumber; i++)
            {
                Console.WriteLine("Note number: " + i);
                string input = Console.ReadLine();
                noteList.Add(input.ToUpper());
                
            }


            while (check == true)
            {
                for (int i = 0; i<notenumber; i++)
                {
                    if (noteList[i] == "A")
                    {
                        new A_note();
}

                    if (noteList[i] == "B")
                    {
                        new B_note();
                    }

                    if (noteList[i] == "C")
                    {
                        new C_note();
                    }

                    if (noteList[i] == "D")
                    {
                        new D_note();
                    }

                    if (noteList[i] == "E")
                    {
                        new E_note();
                    }

                    if (noteList[i] == "F")
                    {
                        new F_note();
                    }

                    if (noteList[i] == "G")
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
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Slutprojekt
{
    class Arpeggiator : Sound
    {
        // int monkey = 0;

       List<string> noteList = new List<string>(); // Listan där valda noter lagras

        public Arpeggiator()
        {

        
        Console.WriteLine("How many notes?");
        int notenumber;


            while (!int.TryParse(Console.ReadLine(), out notenumber))  // Tar input från spelaren,´och output blir antalet noter i arpeggiatorn. 
            {
                
                Console.WriteLine("You entered an invalid number"); // Tvingar spelaren att skriva en siffra.
                Console.Write("enter number of conversations ");

            }

              for (int i = 0; i<notenumber; i++) // Notenumber bestämmer hur många gånger for-loopen ska köras, vilket blir hur mång anoter det skaps och vilken ton de skall ha. 
            {
                Console.WriteLine("Note number: " + i);
                string input = Console.ReadLine();
                noteList.Add(input.ToUpper());
                
            }


            while (check == true) // Medans check är true kommer nedanstående loop köras om och om igen.
            {

                    for (int i = 0; i < notenumber; i++) // Skapar en ny note-objekt, och tonen beror på vilken not som ligger i korresponderande plats i listan.
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

    }

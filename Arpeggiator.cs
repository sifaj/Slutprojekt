using System;
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
        Note A = new A_note();
        Note B = new B_note();
        Note C = new C_note();
        Note D = new D_note();
        Note E = new E_note();
        Note F = new F_note();
        Note G = new G_note();


        List<string> noteList = new List<string>(); // Listan där valda noter lagras
        List<Note> playList = new List<Note>(); 

        

        
       

        public Arpeggiator()
        {
            
        
        Console.WriteLine("How many notes?");
        int notenumber;


            while (!int.TryParse(Console.ReadLine(), out notenumber))  // Tar input från spelaren,´och output blir antalet noter i arpeggiatorn. 
            {
                
                Console.WriteLine("You entered an invalid number"); // Tvingar spelaren att skriva en siffra.
                Console.Write("enter number of notes ");

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
                        A.Play();
                        }

                        if (noteList[i] == "B")
                        {
                        B.Play();
                        }

                        if (noteList[i] == "C")
                        {
                        C.Play();
                        }

                        if (noteList[i] == "D")
                        {
                        D.Play();
                        }

                        if (noteList[i] == "E")
                        {
                        E.Play();
                        }

                        if (noteList[i] == "F")
                        {
                        F.Play();
                        }

                        if (noteList[i] == "G")
                        {
                        G.Play();
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

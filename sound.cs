using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt
{
    class Sound
    {
        protected bool check = true;

        protected List<Note> playList = new List<Note>();


        protected Dictionary<string, Note> noteDict = new Dictionary<string, Note>();


        public Sound()
        {

            noteDict.Add("A", new A_note());
            noteDict.Add("B", new B_note());
            noteDict.Add("C", new C_note());
            noteDict.Add("D", new D_note());
            noteDict.Add("E", new E_note());
            noteDict.Add("F", new F_note());
            noteDict.Add("G", new G_note());

        }



    }
}

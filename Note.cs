using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt
{
    class Note
    {


        public virtual void Beep (int freqeuency)
        {
            Console.Beep(freqeuency, 300);
        }

        public virtual void Play()
        {

        }
    }
}

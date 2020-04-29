using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt
{
    class B_note : Note
    {


        public override void Play()
        {
            Beep(247);
        }

    }
}

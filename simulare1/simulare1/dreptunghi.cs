using System;
using System.Collections.Generic;
using System.Text;

namespace simulare1
{
    class dreptunghi
    {
        dreptunghi(punct a, punct b, punct c,punct d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;

        }
        punct a { get; set; }
        punct b { get; set; }
        punct c { get; set; }
        punct d { set; get; }
    }
}

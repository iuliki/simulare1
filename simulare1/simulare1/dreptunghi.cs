using System;
using System.Collections.Generic;
using System.Text;

namespace simulare1
{
   public class dreptunghi
    {
       public  dreptunghi(punct a, punct b, punct c,punct d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;

        }

        public dreptunghi(punct a, punct c)
        {
            this.a = a;
            this.c = c;
            b.x = c.x;
            b.y = a.y;
            d.x = a.x;
            d.y = c.y;
        }
        public punct a { get; set; } = new punct(0, 0);
        public punct b { get; set; } = new punct(0, 0);
        public punct c { get; set; } = new punct(0, 0);
        public punct d { set; get; } = new punct(0, 0);
    }
}

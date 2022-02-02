using System;
using System.Collections.Generic;
using System.Text;

namespace simulare1
{
    public static class GeometryUtils
    {
        public static void Translate(int ox, int oy,triunghi[] triunghiuri)
        {
            for (int i = 0; i < triunghiuri.Length; i++)
            {
                triunghiuri[i].a.x = triunghiuri[i].a.x + ox;
                triunghiuri[i].a.y = triunghiuri[i].a.y + oy;
                triunghiuri[i].b.x = triunghiuri[i].b.x + ox;
                triunghiuri[i].b.y = triunghiuri[i].b.y + oy;
                triunghiuri[i].c.x = triunghiuri[i].c.x + ox;
                triunghiuri[i].c.y = triunghiuri[i].c.y + oy;


            } 
        }

        public static void Translate(int ox, int oy, dreptunghi[] dreptunghiuri)
        {
            for (int i = 0; i < dreptunghiuri.Length; i++)
            {
                dreptunghiuri[i].a.x = dreptunghiuri[i].a.x + ox;
                dreptunghiuri[i].a.y = dreptunghiuri[i].a.y + oy;
                dreptunghiuri[i].b.x = dreptunghiuri[i].b.x + ox;
                dreptunghiuri[i].b.y = dreptunghiuri[i].b.y + oy;
                dreptunghiuri[i].c.x = dreptunghiuri[i].c.x + ox;
                dreptunghiuri[i].c.y = dreptunghiuri[i].c.y + oy;
                dreptunghiuri[i].d.x = dreptunghiuri[i].d.x + ox;
                dreptunghiuri[i].d.y = dreptunghiuri[i].d.y + oy;

            }

        }

    }
}

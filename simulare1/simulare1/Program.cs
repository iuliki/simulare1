using System;

namespace simulare1
{
    class Program
    {
        static void Main(string[] args)
        {
            triunghi[] triunghiuri = new triunghi[] {
                new triunghi(new punct(1,1),new punct(2,2), new punct(3,3)),
                 new triunghi(new punct(2,2),new punct(3,3), new punct(4,4)),
                 
            };

            GeometryUtils.Translate(1, 1,triunghiuri);


            for (int i = 0;i< triunghiuri.Length;i++)
            {  
                Console.WriteLine(triunghiuri[i].a.x);
                Console.WriteLine(triunghiuri[i].a.y);
                Console.WriteLine(triunghiuri[i].b.x);
                Console.WriteLine(triunghiuri[i].b.y);
                Console.WriteLine(triunghiuri[i].c.x);
                Console.WriteLine(triunghiuri[i].c.y);
            }
           
        }
    }
}

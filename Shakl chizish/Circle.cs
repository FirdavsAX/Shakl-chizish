using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shakl_chizish
{
    internal class Circle : Shakl , IShakl 
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius=radius;
        } 
        public void Draw()
        {
            for (double y =  -Radius; y <= Radius; y++)
            {
                for (int x = -Radius; x <= Radius; x++)
                {
                    double distance = Math.Sqrt(x * x + y * y);
                    if (distance <= Radius)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

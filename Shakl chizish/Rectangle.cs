using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Shakl_chizish
{
    internal class Rectangle : Shakl, IShakl
    {
        public int Eni { get; set; }
        public int Boyi { get; set; }

        public Rectangle(int eni, int boyi)
        {
            Eni=eni;
            Boyi=boyi;
        }

        public void Draw()
        {
            for (int i = 1; i <= Boyi; i++)
            {
                for (int j = 1; j <= Eni; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

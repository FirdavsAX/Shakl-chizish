using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shakl_chizish
{ 
    internal class Uchburchak : Shakl, IShakl
    {
        public Uchburchak(int tomonUzunnligi) { TomonUzunligi = tomonUzunnligi; }
        public int TomonUzunligi { get; set; } = 0;
      
        public void Draw()
        {
            int Width = TomonUzunligi * 2 -1;
            for (int row = 0; row < TomonUzunligi; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    if (col >= TomonUzunligi - row - 1 && col <= TomonUzunligi + row - 1)
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

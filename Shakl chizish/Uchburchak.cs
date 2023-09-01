using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shakl_chizish
{
    internal class Uchburchak : Shakl , IShakl
    {
        public Uchburchak(int tomonUzunnligi) { TomonUzunligi = tomonUzunnligi; }
        public int TomonUzunligi { get; set; }

        public void Draw()
        {
            for (int i = 1; i <= TomonUzunligi; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

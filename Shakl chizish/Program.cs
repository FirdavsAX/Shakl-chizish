using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace Shakl_chizish
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello choose the shape");

            Console.WriteLine("1.Rectangle");
            Console.WriteLine("2.Triangle");
            Console.WriteLine("3.Circle");
            Console.WriteLine("0.Exit");

            IShakl shape;

            int.TryParse(Console.ReadLine(), out int choice);

            switch (choice)
            {
                case 1: shape = new Rectangle(10, 8); break;
                case 2: shape = new Uchburchak(8); break;
                case 3: shape = new Circle(8); break;
                default: shape = new Rectangle(12,2);break;
            }
            Display(shape);
            Main(args);

        }
        public static void Display(IShakl shape)
        {
            shape.Draw();
        }
    }
}
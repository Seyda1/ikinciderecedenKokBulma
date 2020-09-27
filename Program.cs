using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,delta,kök1,kök2,y;
            Console.WriteLine("İikini dereceden denklemin a,b,c katsayılarını giriniz");
            a=Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            delta=(b*b)-(4*a*c);
           
            if (delta < 0)
            {
                Console.WriteLine("denklemin gerçel kökü yoktur");

            }
            else
            {
                Console.WriteLine("denklemin kökü vardır");
                kök1 = (-b-(Math.Sqrt(delta)))/(2*a);
                kök2 = (-b + (Math.Sqrt(delta))) /( 2 * a);
                Console.WriteLine("bu kökler {0},{1}",kök1,kök2);

            }
            Console.ReadLine();

        }
    }
}

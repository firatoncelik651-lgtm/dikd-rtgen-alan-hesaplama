using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dikdörtgen_alan_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kısa kenarı giriniz.");
            int kisaKenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun kenarı giriniz.");
            int uzunKenar = Convert.ToInt32(Console.ReadLine());
            int alan = kisaKenar * uzunKenar;
            Console.WriteLine("Alan: " + alan);
            Console.ReadLine();

        }
    }
}

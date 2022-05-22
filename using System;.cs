using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
         
        static void Main(string[] args)
        {


            List<int> kus_turu = new List<int>();

            
            Console.WriteLine("kuş türünü giriniz 0 girene kadar devam ediniz 0 girince liste tamamlanacaktır.");
            int gir = int.Parse(Console.ReadLine());

            while (gir >= 1)
            {
                kus_turu.Add(gir);
                gir = int.Parse(Console.ReadLine());
            }

            var mod = ModBul(kus_turu);
            Console.WriteLine("Mod : " + mod);
            Console.ReadKey();
        }

        static int ModBul(List<int> list)
        {
            var grouped = list.GroupBy(x => x).OrderByDescending(x=> x.Count()).ThenBy(x=> x.Key);
            return grouped.FirstOrDefault().Key;
         
        }
    }
}
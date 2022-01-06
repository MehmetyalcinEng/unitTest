using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            topla();
            Console.ReadKey();
        }

        public static void topla()
        {

            Console.WriteLine("1. sayıyı girin");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayıyı girin");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("toplam:" + (sayi1 + sayi2));
        }
    }
}

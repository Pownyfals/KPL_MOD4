using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204081
{
	public class Penjumlahan<T> where T : struct
	{
        static void Main(string[] args)
        {

            jumlahTigaAngka(13, 22, 40);
        }
        public static void jumlahTigaAngka<T>(T a, T b, T c) where T : struct
		{

            dynamic x = a;
            dynamic y = b;
            dynamic z = c;
            Console.WriteLine(x + y + z);
		}
        
        


    }
}

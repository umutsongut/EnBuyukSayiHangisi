using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnBuyukSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Sıralayıcıya Hoşgeldiniz! | developed by Mors.");
            Console.WriteLine(new string('-', 70));

            Console.Write("Kaç Sayılık İşlem Yapmak İstersiniz?: ");
            int giris = Convert.ToInt32(Console.ReadLine());

            int[] siralama = new int[giris];

            for (int m = 0; m < giris; m++)
            {
                Console.Clear();
                Console.Write((m + 1).ToString() + ".Sayıyı Girin: ");
                siralama[m] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine();

            int enbuyuk;
            enbuyuk = siralama[0];

            for (int i = 0; i < giris; i++)
            {
                if (enbuyuk < siralama[i])
                {
                    enbuyuk = siralama[i];
                }
            }
            Console.Write($"En Büyük Sayı:{enbuyuk}");

            Console.Read();
        }
    }
}

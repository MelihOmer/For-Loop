using System;

namespace Donguler_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Bir Sayı Giriniz.");
            //Ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır.
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i%2 ==1)
                {
                    System.Console.WriteLine(i);
                }
                //Komutlarımız
            }
            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.
            int tektoplam = 0;
            int cifttoplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i%2 == 1)
                {
                    tektoplam += i;// tektoplam = tektoplam + i;
                }
                else
                {
                    cifttoplam += i;
                }
            }
            System.Console.WriteLine("Tek Sayıların Toplamı : " + tektoplam);
            System.Console.WriteLine("Çift Sayıların Toplamı : " + cifttoplam);

            //break,continue
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

        }
    }
}

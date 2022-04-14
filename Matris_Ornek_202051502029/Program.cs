using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matris_Ornek_202051502029
{
    class Program
    {
        static void Main(string[] args)
        {
            int sA, sB;
            Console.WriteLine("Çarpacağınız Matrislerin Boyutlarını Giriniz: ");
            sA = Convert.ToInt32(Console.ReadLine());
            sB = Convert.ToInt32(Console.ReadLine());

            int[,] matris1 = new int[sA, sB]; //First Matris
            int[,] matris2 = new int[sB, sA];  //Second Matris
            int[,] Sonuc = new int[sA, sA];

            Console.WriteLine("<--  Matris 1 -->");
            for (int i = 0; i < sA; i++)
            {
                for (int k = 0; k < sB; k++)
                {

                    Console.Write(i + ". Satırın " + k + ". Elemanı: ");
                    matris1[i, k] = Convert.ToInt32(Console.ReadLine());


                }
            }
            Console.WriteLine("<-- Matris 2 -->");
            for (int i = 0; i < sB; i++)
            {
                for (int k = 0; k < sA; k++)
                {
                    Console.Write(i + ". Satırın " + k + ". Elemanı: ");
                    matris2[i, k] = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.WriteLine("<---1. matris--->");
            for (int i = 0; i < sA; i++)
            {
                for (int k = 0; k < sB; k++)
                {
                    Console.Write(matris1[i, k]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("<---2. matris--->");
            for (int i = 0; i < sB; i++)
            {
                for (int k = 0; k < sA; k++)
                {
                    Console.Write(matris2[i, k]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            //Çarpma İşlemini Yapıyoruz.
            for (int i = 0; i < sA; i++)
            {
                for (int k = 0; k < sA; k++)
                {
                    for (int j = 0; j < sB; j++)
                    {
                        Sonuc[i, k] += matris1[i, j] * matris2[j, k];
                    }
                }
            }
            Console.WriteLine("<---Matrislerin Çarpımlarının Sonucu--->");
            for (int i = 0; i < sA; i++)
            {
                for (int k = 0; k < sA; k++)
                {
                    Console.Write(Sonuc[i, k]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

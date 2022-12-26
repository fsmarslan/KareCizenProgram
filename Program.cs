using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareCizenProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kare Yapma Uygulamasına Hoşgeldiniz!");
            Console.WriteLine();
            char cevap;
            do
            {
                Console.Write("Karenin kenar uzunluğunu belirleyiniz: ");
                int kenar = int.Parse(Console.ReadLine());
                for (int i = 0; i < kenar; i++)
                {
                    string metin = "";
                    for (int j = 0; j < kenar; j++)
                    {
                        metin += " *";
                    }
                    Console.WriteLine(metin);
                }
                Console.WriteLine("Tekrar yapmak ister misiniz? (e/h) ");
                cevap = Convert.ToChar(Console.ReadLine());
            } while (cevap=='e');
            Console.WriteLine("Uygulamamızı kullandığınız için teşekkürler.");
            Console.ReadKey();
        }
    }
}

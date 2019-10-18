using System;

namespace ScontiVari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quale è l'importo della spesa ?");
            double importo = double.Parse(Console.ReadLine());
            if (importo<=500)
            {
                double sconto1 = (importo * 10) / 100;
                double finale1 = importo - sconto1;
                Console.WriteLine($"lo sconto è di {sconto1:c} e l'imprto finale è di {finale1:c}");
            }
            if (importo>500)
            {
                double sconto2 = (importo * 20) / 100;
                double finale2 = importo - sconto2;
                Console.WriteLine($"lo sconto è di {sconto2:c} e l'imprto finale è di {finale2:c}");
            }
            Console.ReadLine();
        }
    }
}

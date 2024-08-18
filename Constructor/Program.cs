
using System;
namespace Constructor
{
    public class program
    {
        static void Main(string[] args)
        {
            Bebek bebek1 = new Bebek();
            Console.WriteLine("Bebek 1 Bilgileri:");
            bebek1.Yazdırma();
            Console.WriteLine();

            // Parametreli constructor ile bebek nesnesi oluşturma
            Bebek bebek2 = new Bebek("Ali", "Veli");
            Console.WriteLine("Bebek 2 Bilgileri:");
            bebek2.Yazdırma();
        }
    }










}

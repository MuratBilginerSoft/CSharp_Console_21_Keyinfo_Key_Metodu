using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console_key_ınfometodu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Not Üniversite 1 de iken ders anında aldığım notlar açıklama satırları. Nostalji olması açısından silmedim :D

            // anladığım kadarıyla keyinfo metodunda şu satır kod kesin kullanılacak
            // system.consolekeyinfo keyinfo= console.readkey(true);
            // konsole ekranını kapatmak için system.environment.exit(0); kodu kullanılabiir.
            // bastığımız tuşu keyinfo ya atamak için keyinfo.key==consolekey.istediğimiz tuş

            // 1. PROGRAM

            Console.Write("Bir tuşa basınız: ");

            System.ConsoleKeyInfo KeyInfo = Console.ReadKey(true);

            Console.Write(KeyInfo.Key.ToString() + "  tuşuna bastınız");

            Console.ReadKey();

            Console.Clear(); // bu metod ekranımızı temizlemize yardımcı olur.

/* **************************************************************************************** */
            // 2. PROGRAM

            string ad, soyad;

            Console.WriteLine("Adınızı Giriniz:");

            ad = Console.ReadLine();

            Console.WriteLine("Soyadınızı Giriniz:");

            soyad = Console.ReadLine();

            Console.Clear(); // Bu metod console ekranını temizlememize yardımcı olur.

            Console.WriteLine("Ekrana yazdırmak için F2, Çıkmak için ESC tuşuna basınız!!!");

            ConsoleKeyInfo a = Console.ReadKey();

            if (a.Key == ConsoleKey.Escape)
            {

                System.Environment.Exit(0); // programı kapatmamızı sağladı. 
                 

            }

            else if (a.Key == ConsoleKey.F2)

                Console.Write(ad + " " + soyad);

            Console.ReadKey();
            
            Console.ReadKey();
        }


    }
}

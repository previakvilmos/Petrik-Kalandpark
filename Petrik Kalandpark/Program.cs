using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrik_Kalandpark
{
    internal class Program
    {
        static void MenuKiir()
        {
            Console.Clear();
            Console.WriteLine("=== PETRIK KALANDPARK ===\n");
            Console.WriteLine("1.) Napijegy vásárlása");
            Console.WriteLine("2.) Pálya választása");
            Console.WriteLine("3.) Kupon kalkulátor");
            Console.WriteLine("4.) Napi bevétel");
            Console.WriteLine("5.) Kilépés\n");
            Console.Write("Választás: ");
        }
        static string JegyTipus(int eletkor)
        {
            string jegytipus;
            if (eletkor < 8)
            {
                jegytipus = "Mini jegy";
            }
            else if (eletkor < 16)
            {
                jegytipus = "Junior jegy";
            }
            else if (eletkor < 25)
            {
                jegytipus = "Ifjúsági jegy";
            }
            else if (eletkor < 60)
            {
                jegytipus = "Felnőtt jegy";
            }
            else
            {
                jegytipus = "Senior jegy";
            }
            return jegytipus;
        }
        static int JegyAr(int eletkor)
        {
            int jegyar;
            if (eletkor < 8)
            {
                jegyar = 1000;
            }
            else if (eletkor < 16)
            {
                jegyar = 2200;
            }
            else if (eletkor < 25)
            {
                jegyar = 3000;
            }
            else if (eletkor < 60)
            {
                jegyar = 4500;
            }
            else
            {
                jegyar = 2800;
            }
            return jegyar;
        }


        static void PalyaValasztas(int palyavalasztas, int magassag)
        {
            switch (palyavalasztas)
            {
                case 1:
                    if(magassag < 90)
                    {
                        Console.WriteLine("Nem használhatod ezt a pályát!");   
                    }
                    else
                    {
                        Console.WriteLine("Használhatod ezt a pályát!");
                    }
                    break;
                case 2:
                    if (magassag < 130)
                    {
                        Console.WriteLine("Nem használhatod ezt a pályát!");
                    }
                    else
                    {
                        Console.WriteLine("Használhatod ezt a pályát!");
                    }
                    break;
                case 3:
                    if (magassag < 160)
                    {
                        Console.WriteLine("Nem használhatod ezt a pályát!");
                    }
                    else
                    {
                        Console.WriteLine("Használhatod ezt a pályát!");
                    }
                    break;
                default:
                    Console.WriteLine("Nincs ilyen pálya");
                    break;
            }
        }
        static int KuponosAr(int eredetiar, int kupon)
        {
            int ar = 0;
            switch (kupon)
            {
                case 1:
                    ar = eredetiar;
                    break;
                case 2:
                    ar = eredetiar * 90 / 100;
                    break;
                case 3:
                    ar = eredetiar * 75 / 100;
                    break;
                default:
                    Console.WriteLine("Nincs ilyen kupon!");
                    break;
            }
            return ar;
        }


        static void Main(string[] args)
        {
            int valasztas = 0;
            int osszar = 0;
            do {
               
                try
                {
                  MenuKiir();
                  valasztas = Convert.ToInt32(Console.ReadLine());
                    switch (valasztas)
                    {
                        case 1:
                            int eletkor = 0;
                            Console.Clear() ;
                            Console.WriteLine("=== NAPIJEGY VÁSÁRLÁSA ===\n");
                            Console.Write("Név: ");
                            string nev = Console.ReadLine();
                            
                            do
                            {
                                Console.Write("Életkor: ");
                                eletkor = Convert.ToInt32(Console.ReadLine());
                                if (eletkor > 119 || eletkor < 1)
                                {
                                    Console.WriteLine("Hibás életkor!");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                            } while (eletkor > 119 || eletkor < 1);
                            Console.WriteLine($"\nSzia {nev}!");
                            Console.WriteLine($"Jegytípus: {JegyTipus(eletkor)}");
                            Console.WriteLine($"Fizetendő: {JegyAr(eletkor)}");
                            Console.ReadLine();
                            osszar = JegyAr(eletkor);
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("=== KALANDPÁLYÁK ===\n");
                            Console.WriteLine("1.) Gyerekpálya");
                            Console.WriteLine("2.) Erdei pálya");
                            Console.WriteLine("3.) Extrém pálya\n");
                            Console.Write("Választás: ");
                            int palyavalasztas = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Magasság: ");
                            int magassag = Convert.ToInt32(Console.ReadLine());
                            PalyaValasztas(palyavalasztas, magassag);
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("=== KUPON KALKULÁTOR ===\n");
                            Console.Write("Eredeti ár: ");
                            int eredetiar = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n1.) Nincs ilyen kupon");
                            Console.WriteLine("2.) SILVER kupon - 10%");
                            Console.WriteLine("3.) GOLD kupon - 25%");
                            Console.Write("\nKupon: ");
                            int kupon = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Eredeti ár: {eredetiar}");
                            Console.WriteLine($"Kupon: {kupon}\n");
                            Console.WriteLine($"Fizetendő: {KuponosAr(eredetiar, kupon)} Ft");
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.Clear() ;
                            Console.WriteLine("=== NAPI BEVÉTEL ===\n");
                            Console.WriteLine($"A kalandpark napi bevétele: {osszar} Ft");
                            Console.ReadLine() ;
                            break;
                        case 5:
                            Console.WriteLine("Viszlát!");
                            break;
                        default:
                            Console.WriteLine("Nincs ilyen opció!");
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Hiba! Számot kell megadni!");
                    Console.ReadLine() ;
                }
            } while (valasztas != 5);
        }
    }
}

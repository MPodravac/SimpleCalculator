using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculation;

namespace ConsoleAppCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float fPrviBr, fDrugiBr, fRezultat = 0;
            int nOdabir;

            Console.WriteLine("Unesite prvi broj:");
            fPrviBr = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj:");
            fDrugiBr = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Odaberite operaciju");
            Console.WriteLine();
            Console.WriteLine("1. Zbrajanje");
            Console.WriteLine("2. Mnozenje");
            Console.WriteLine("3. Oduzimanje");
            Console.WriteLine("4. Dijeljenje");
            Console.WriteLine();
            nOdabir = Convert.ToInt32(Console.ReadLine());

            Calculator Calculator = new Calculator();

            switch (nOdabir)
            {
                case 1:
                    // fRezultat = fPrviBr + fDrugiBr;
                    fRezultat = Calculator.Add(fPrviBr, fDrugiBr);
                    break;
                case 2:
                    //fRezultat = fPrviBr * fDrugiBr;
                    fRezultat = Calculator.Multiply(fPrviBr, fDrugiBr);
                    break;
                case 3:
                    //fRezultat = fPrviBr - fDrugiBr;
                    fRezultat = Calculator.Substract(fPrviBr, fDrugiBr);
                    break;
                case 4:
                    //fRezultat = fPrviBr / fDrugiBr;
                    fRezultat = Calculator.Divide(fPrviBr, fDrugiBr);
                    break;
                default:
                    Console.WriteLine("Odabrali ste nepostojecu operaciju");
                    break;
            }

            Console.WriteLine("Rezultat zeljene operacije je " + fRezultat);
            Console.ReadKey();
        }
    }
}

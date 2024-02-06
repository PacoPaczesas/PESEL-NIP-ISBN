using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESEL_NIP_ISBN
{
    internal class UserInput
    {
        public static string StringGetNumber(string name, int length)
        {
            string number;
            bool onlyNumbers = true;

            do
            {
                if (onlyNumbers == false)
                {
                    Console.Write("Wprowadzono błędny " + name + ". Pamiętaj, że " + name + " składa się wyłączenie ze znaków od 0 - 9 i jest to ciąg " + length + " znaków. ");
                }
                else
                {
                    Console.Write("Wprowadź nr " + name + ": ");
                }
                number = Console.ReadLine();
                onlyNumbers = true;
                foreach (char ch in number)
                {
                    if (!char.IsDigit(ch))
                    {
                        onlyNumbers = false;
                        break;
                    }
                }

                if (number.Length != length)
                {
                    onlyNumbers = false;
                }
            } while (number.Length != length || !onlyNumbers);

            return number;
        }

        public static int GetNumber(int a, int b)
        {
            Console.Write("podaj liczbe całkowitą z przediału od " + a + " do " + b + ": ");
            int liczba;
            do
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out liczba))
                {
                    if (liczba >= a && liczba <= b)
                    {
                        return liczba;
                    }
                    else
                    {
                        Console.WriteLine("Błędna wartość. podaj liczbe całkowitą z przediału od " + a + " do " + b);
                    }
                }
                else
                {
                    Console.WriteLine("Błędna wartość. podaj liczbe całkowitą z przediału od " + a + " do " + b);
                }
            } while (true);
        }

        public static int[] StringToTab (string stringNumber, int tabLength) 
        {
            int[] tab = new int[tabLength];
            int number;
            char c;

            for (int i = 0; i < stringNumber.Length; i++)
            {
                c = stringNumber[i];
                number = (int)(c - '0');
                tab[i] = number;
            }

            return tab;
        }
    }
    internal class Checking
    {
        public static void CheckPESEL(int[] tabPESEL)
        {
            int n1 = notMoreThen10(tabPESEL[0] * 1);
            int n2 = notMoreThen10(tabPESEL[1] * 3);
            int n3 = notMoreThen10(tabPESEL[2] * 7);
            int n4 = notMoreThen10(tabPESEL[3] * 9);
            int n5 = notMoreThen10(tabPESEL[4] * 1);
            int n6 = notMoreThen10(tabPESEL[5] * 3);
            int n7 = notMoreThen10(tabPESEL[6] * 7);
            int n8 = notMoreThen10(tabPESEL[7] * 9);
            int n9 = notMoreThen10(tabPESEL[8] * 1);
            int n10 = notMoreThen10(tabPESEL[9] * 3);
            int controlNumber = 10 - notMoreThen10(n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10);

            if (controlNumber == tabPESEL[10]) {
                Console.WriteLine("PESEL jest poprawny");
                Console.WriteLine("Data urodzenia to - dzień: " + tabPESEL[4] + tabPESEL[5] + ", miesiąc: " + tabPESEL[2] + tabPESEL[3] + ", rok: 19" + tabPESEL[0] + tabPESEL[1]);
                if (tabPESEL[9] % 2 == 2)
                {
                    Console.WriteLine("Płeć: kobieta");
                }
                else
                {
                    Console.WriteLine("Płeć: mężczyzna");
                }
            }
            else
            {
                Console.WriteLine("Pesel nie jest poprawny");
            }
        }
        public static int notMoreThen10(int n)
        {
            while (n > 9)
            {
                n -= 10;
            }
            return n;
        }

        public static void CheckNIP(int[] tabNIP)
        {
                int n1 = tabNIP[0] * 6;
                int n2 = tabNIP[1] * 5;
                int n3 = tabNIP[2] * 7;
                int n4 = tabNIP[3] * 2;
                int n5 = tabNIP[4] * 3;
                int n6 = tabNIP[5] * 4;
                int n7 = tabNIP[6] * 5;
                int n8 = tabNIP[7] * 6;
                int n9 = tabNIP[8] * 7;
                int controlNumber = (n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9) % 11;

                if (controlNumber == tabNIP[9]) {
                    Console.WriteLine("NIP jest prawidłowy");
                }
                else
                {
                    Console.WriteLine("NIP jest nieprawidłowy");
                }

         }

        public static void CheckISBN(int[] tabISBN)
        {
            int n1 = tabISBN[0];
            int n2 = tabISBN[1] * 3;
            int n3 = tabISBN[2];
            int n4 = tabISBN[3] * 3;
            int n5 = tabISBN[4];
            int n6 = tabISBN[5] * 3;
            int n7 = tabISBN[6];
            int n8 = tabISBN[7] * 3;
            int n9 = tabISBN[8];
            int n10 = tabISBN[9] * 3;
            int n11 = tabISBN[10];
            int n12 = tabISBN[11] * 3;
            int controlNumber = (n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10 + n11 + n12) % 10;

            if (controlNumber == tabISBN[12])
            {
                Console.WriteLine("ISBN jest prawidłowy");
            }
            else
            {
                Console.WriteLine("ISBN jest nieprawidłowy");
            }


        }




    }
}

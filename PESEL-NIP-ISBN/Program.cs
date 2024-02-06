using PESEL_NIP_ISBN;


Console.WriteLine("Program sprawdzający poprawność wprowadzonych numerów.");


bool exit = false;

string number;


do
{
    Console.WriteLine("Jaki numer chcesz sprawdzić?");
    Console.WriteLine("1. PESEL");
    Console.WriteLine("2. NIP");
    Console.WriteLine("3. ISBN");
    Console.WriteLine("4. Wyjdź");
    Console.Write("Wybierz opcje z menu: ");
    int menuOption = UserInput.GetNumber(1, 4);


    switch (menuOption)
    {
        case 1:
            number = UserInput.StringGetNumber("PESEL", 11);
            int[] tabPESEL = new int[11];
            tabPESEL = UserInput.StringToTab(number, 11);
            Checking.CheckPESEL(tabPESEL);
            Console.WriteLine(" ");
            break;

        case 2:
            number = UserInput.StringGetNumber("NIP", 10);
            int[] tabNIP = new int[10];
            tabNIP = UserInput.StringToTab(number, 10);
            Checking.CheckNIP(tabNIP);
            Console.WriteLine(" ");
            break;

        case 3:
            number = UserInput.StringGetNumber("ISBN", 13);
            int[] tabISBN = new int[13];
            tabISBN = UserInput.StringToTab(number, 13);
            Checking.CheckISBN(tabISBN);
            Console.WriteLine(" ");
            break;

        case 4:
            exit = true;
            break;

        default:
            Console.WriteLine("Błąd");
            break;
    }

} while (!exit);

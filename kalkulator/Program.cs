using System.Reflection.Metadata;

class kalkulator
{
    private static void Main(string[] args)
    {
        bool zakonczyc = true;
        int liczba_podstawowa;
        int przesuniecie;
        string kierunek;
        Console.Clear();
        Console.WriteLine("Wybierz opcje:");
        Console.WriteLine("1.Kalkulator prosty");
        Console.WriteLine("2.Kalkulator programistyczny");
        int opcja = int.Parse(Console.ReadLine());
        if (opcja == 1)
        {
            float wynik = 0;
            char znak;
            Console.Clear();
            Console.WriteLine("Podaj liczbe:");
            wynik = float.Parse(Console.ReadLine());
            while (zakonczyc)
            {
                Console.Clear();
                Console.WriteLine("Podaj znak operacji(+,-,*,/):");
                znak = char.Parse(Console.ReadLine());
                if (znak == '+')
                {
                    Console.WriteLine("Podaj liczbe:");
                    wynik += float.Parse(Console.ReadLine());
                }
                else if (znak == '-')
                {
                    Console.WriteLine("Podaj liczbe:");
                    wynik -= float.Parse(Console.ReadLine());
                }
                else if (znak == '*')
                {
                    Console.WriteLine("Podaj liczbe:");
                    wynik *= float.Parse(Console.ReadLine());
                }
                else if (znak == '/')
                {
                    Console.WriteLine("Podaj liczbe:");
                    wynik /= float.Parse(Console.ReadLine());
                }
                Console.WriteLine("Wynik:" + wynik);
                Console.WriteLine("Kontynuowac?(true/false):");
                zakonczyc = bool.Parse(Console.ReadLine());
            }
        }
        else if (opcja == 2)
        {
            Console.Clear();
            Console.WriteLine("Wybierz funkcje: ");
            Console.WriteLine("1. Zamiana systemow liczbowych");
            Console.WriteLine("2. Przesuniecie bitowe");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                while (zakonczyc)
                {
                    Console.Clear();
                    Console.WriteLine("Wybierz system liczbowy wejsciowy:");
                    Console.WriteLine("1.System dziesietny");
                    Console.WriteLine("2.System dwojkowy");
                    Console.WriteLine("3.System osemkowy");
                    Console.WriteLine("4.System szesnastkowy");
                    int opcjaprog = int.Parse(Console.ReadLine());
                    switch (opcjaprog)
                    {
                        case 1:
                            Console.WriteLine("Podaj liczbe w systemie dziesietnym:");
                            int liczba = int.Parse(Console.ReadLine());
                            Console.WriteLine($"System binarny: {Convert.ToString(liczba, 2)}");
                            Console.WriteLine($"System ósemkowy: {Convert.ToString(liczba, 8)}");
                            Console.WriteLine($"System szesnastkowy: {Convert.ToString(liczba, 16)}");
                            Console.WriteLine("Kontynuowac?(true/false):");
                            zakonczyc = bool.Parse(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Podaj liczbe w systemie dwojkowy:");
                            string liczba2 = Console.ReadLine();
                            Console.WriteLine($"System dziesiętny: {Convert.ToInt32(liczba2, 2)}");
                            Console.WriteLine($"System ósemkowy: {Convert.ToString(Convert.ToInt32(liczba2, 2), 8)}");
                            Console.WriteLine($"System szesnastkowy: {Convert.ToString(Convert.ToInt32(liczba2, 2), 16)}");
                            Console.WriteLine("Kontynuowac?(true/false):");
                            zakonczyc = bool.Parse(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Podaj liczbe w systemie osemkowy:");
                            string liczba3 = Console.ReadLine();
                            Console.WriteLine($"System dziesiętny: {Convert.ToInt32(liczba3, 8)}");
                            Console.WriteLine($"System binarne: {Convert.ToString(Convert.ToInt32(liczba3, 8), 2)}");
                            Console.WriteLine($"System szesnastkowe: {Convert.ToString(Convert.ToInt32(liczba3, 8), 16)}");
                            Console.WriteLine("Kontynuowac?(true/false):");
                            zakonczyc = bool.Parse(Console.ReadLine());
                            break;
                        case 4:
                            Console.WriteLine("Podaj liczbe w systemie szestnastkowy:");
                            string liczba4 = Console.ReadLine();
                            Console.WriteLine($"System dziesiętny: {Convert.ToInt32(liczba4, 16)}");
                            Console.WriteLine($"System binarne: {Convert.ToString(Convert.ToInt32(liczba4, 16), 2)}");
                            Console.WriteLine($"System ósemkowe: {Convert.ToString(Convert.ToInt32(liczba4, 16), 8)}");
                            Console.WriteLine("Kontynuowac?(true/false):");
                            zakonczyc = bool.Parse(Console.ReadLine());
                            break;
                    }
                }
            }else if (x == 2)
            {
                Console.Clear();
                Console.WriteLine("Podaj liczbe: ");
                liczba_podstawowa = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj o ile chcesz przesunac: ");
                przesuniecie = int.Parse(Console.ReadLine());
                Console.WriteLine("Przesuwamy w lewo, czy w prawo?");
                kierunek = Console.ReadLine();
                if (kierunek == "prawo") {
                    Console.WriteLine("Przesunieta liczba: " + (liczba_podstawowa>>przesuniecie));
                } else if(kierunek == "lewo"){
                    Console.WriteLine("Przesunieta liczba: " + (liczba_podstawowa << przesuniecie));
                }
            }
        }
    }
}
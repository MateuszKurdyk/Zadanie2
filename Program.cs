using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
namespace Zadanie2;
//klasy
//  klasa pizza 
//    nazwa, rodzaj, cena
//  klasa dostawa
//    rodzaj dostawy, ilosc km, cena za km
//  klasa dodatki
//    nazwa, cena, ilosc

//Tworzymy klase
class Pizza
{
    // potem w klasie definujemy typy danych i nazwy dla naszych zmiennych
    // zmiana ceny z string na int do łatwiejszej obsługi
    public string Nazwa { get; set; }
    public string Rodzaj { get; set; }
    public int Cena { get; set; }

    // tutaj znajduje sie funkcja (konstruktor) dzieki której mozemy potem tworzyc obiekty tej klasy
    public Pizza(string nazwa, string rodzaj, int cena)
    {
        Nazwa = nazwa;
        Rodzaj = rodzaj;
        Cena = cena;
    }
    // informacja zwrotna o pizzy (juz przy okreslonym obiekcie mozemy wyswietlic informacje o nim)
    public void PizzaInfo()
    {
        Console.WriteLine($"Wybrana pizza to {Nazwa} jej rodzaj to {Rodzaj}, cena to {Cena} zł");
    }

}
class Dostawa
{
    public string RodzajDostawy { get; set; }
    public int Odleglosc { get; set; }
    public int CenaKm { get; set; }

    public Dostawa(string rodzajDostawy, int odleglosc, int cenaKm)
    {
        RodzajDostawy = rodzajDostawy;
        Odleglosc = odleglosc;
        CenaKm = cenaKm;
    }
    public void DostawaInfo()
    {
        Console.WriteLine($"Wybrany rodzaj dostawy to {RodzajDostawy}, odleglosc to {Odleglosc} km, cena za km to {CenaKm} zł");
    }
}
class Dodatki
{
    public string Nazwa { get; set; }
    public int Cena { get; set; }
    public int Ilosc { get; set; }

    public Dodatki(string nazwa, int cena, int ilosc)
    {
        Nazwa = nazwa;
        Cena = cena;
        Ilosc = ilosc;
    }

    public void DodatkiInfo()
    {
        Console.WriteLine($"Wybrany dodatek to {Nazwa}, cena to {Cena} zł, ilosc to {Ilosc}");
    }
}
class Program
{
    static void Main()
    {
        // Dynamincza tablica czyli lista
        // ułatwia to wybór w menu, bo nie musimy tworzyc ciagle nowych zmiennych
        // Tylko dodajemy nowe obiekty do listy i potem je sprawdzać za pomocą pętli
        var tabPizza = new List<Pizza>();
        tabPizza.Add(new Pizza("Salami", "Klasyczna", 20));
        tabPizza.Add(new Pizza("Pepperoni", "Ostra", 25));
        tabPizza.Add(new Pizza("Hawajska", "Słodka", 22));

        Console.WriteLine("Witaj w pizzerii, zamów swoją pizzę!");
        Console.WriteLine("Menu: 1. Salami, 2. Pepperoni, 3. Hawajska");
        int wyborPizzy = int.Parse(Console.ReadLine());

        // dzięki liście mozemy posłuzyc się pętlą do sprawdzenia wybranej pizzy i wyświetlenia jej
        for (int i = 0; i < tabPizza.Count; i++)
        {
            if (wyborPizzy == i + 1)
            {
                tabPizza[i].PizzaInfo();
            }
        }

        var tabDostawa = new List<Dostawa>();
        // implementacja przed ifami itd. zeby miec dostęp do zmiennej
        int odleglosc = 0;
        tabDostawa.Add(new Dostawa("Odbiór osobisty", 0, 0));
        tabDostawa.Add(new Dostawa("Na miejscu", 0, 0));
        tabDostawa.Add(new Dostawa("Dowóz", odleglosc, 2));

        Console.WriteLine("Wybierz rodzaj dostawy: 1.Odbiór osobisty , 2. Na miejscu, 3. Dowóz");
        int wyborDostawy = int.Parse(Console.ReadLine());
        for (int i = 0; i < tabDostawa.Count; i++)
        {
            if (wyborDostawy == 3)
            {
                Console.WriteLine("Podaj odległość w km:");
                odleglosc = int.Parse(Console.ReadLine());
                // aktualizacja zmiennej odleglosc w obiekcie dowozu
                tabDostawa[2].Odleglosc = odleglosc;
                break;
            }
            else if (wyborDostawy == i + 1)
            {
                tabDostawa[i].DostawaInfo();
            }
        }


        var tabDodatki = new List<Dodatki>();
        tabDodatki.Add(new Dodatki("Oliwki", 3, 0));
        tabDodatki.Add(new Dodatki("Pieczarki", 3, 0));
        tabDodatki.Add(new Dodatki("Papryka", 3, 0));


        Console.WriteLine("Czy chcesz dodać dodatki do pizzy? tak/nie");
        string wyborDodatkow = Console.ReadLine();
        // Dostep do zmiennej z if-a
        int wybraneDodatki = 0;
        if (wyborDodatkow.ToLower() == "tak")
        {
            while (true)
            {
                //dodawanie do obiektu ilosci dodatkow wiec mamy na biezaco informacje ile jest danych dodatkow
                Console.WriteLine("Wybierz dodatki do pizzy (3zł szt):");
                Console.WriteLine("Dostępne dodatki: 1. Oliwki, 2. Pieczarki, 3. Papryka");
                wybraneDodatki = int.Parse(Console.ReadLine());

                for (int i = 0; i < tabDodatki.Count; i++)
                {
                    if (wybraneDodatki == i + 1)
                    {
                        // Dodawnie ilosci do obiektu
                        tabDodatki[i].Ilosc += 1;
                        tabDodatki[i].DodatkiInfo();
                    }
                }
                Console.WriteLine("Czy chcesz dodać kolejny dodatek? tak/nie");
                wyborDodatkow = Console.ReadLine();
                if (wyborDodatkow.ToLower() != "tak")
                {
                    // Mozliwosc dodawania wielu dodatkow, ale jesli tylko jeden mozna przerwac dodawanie
                    break;
                }
            }
            // TODO
            // menu wyboru pizzy, prosi o wybór pizzy, wybór dodatków i dostawy, a potem podsumowanie
            // funkcja która przy wyborze dowozu prosi o podanie odległości.
        }
        // Dzięki stworzeniu pizzaInfo itd. nie musimy się bawić z Console.WriteLine
        Console.WriteLine("Dziękujemy za zamówienie! Smacznego!");
        Console.WriteLine("Podsumowanie zamówienia:");
        tabPizza[wyborPizzy - 1].PizzaInfo();
        Console.WriteLine($"Cena za pizzę to: {tabPizza[wyborPizzy - 1].Cena} zł");
        tabDostawa[wyborDostawy - 1].DostawaInfo();
        Console.WriteLine($"Cena za dostawe to: {tabDostawa[wyborDostawy - 1].Odleglosc * tabDostawa[wyborDostawy - 1].CenaKm} zł");
        int suma = 0;
        //sprawdzanie czy sa jakiekolwiek dodatki do wyswietlenia 
        for (int i = 0; i < tabDodatki.Count; i++)
        {
            if (tabDodatki[i].Ilosc > 0)
            {
                // Dodanie ceny dodatków do sumy (cena * ilosc)
                suma += tabDodatki[i].Cena * tabDodatki[i].Ilosc;
                tabDodatki[i].DodatkiInfo();
            }
        }
        // Dodanie ceny dostawy i pizzy do sumy dodatków
        suma += (tabDostawa[wyborDostawy - 1].Odleglosc * tabDostawa[wyborDostawy - 1].CenaKm) + tabPizza[wyborPizzy - 1].Cena;
        Console.WriteLine($"Razem: {suma} zł");
    }
}

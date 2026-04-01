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
    public string Nazwa { get; set;}
    public string Rodzaj { get; set;}
    public string Cena { get; set;}
    
    // tutaj znajduje sie funkcja (konstruktor) dzieki której mozemy potem tworzyc obiekty tej klasy
    public Pizza(string nazwa, string rodzaj, string cena)
    {
        Nazwa = nazwa;
        Rodzaj = rodzaj;
        Cena = cena;
    }
    // informacja zwrotna o pizzy (juz przy okreslonym obiekcie mozemy wyswietlic informacje o nim)
    public void PizzaInfo()
   {
        Console.WriteLine($"Wybrana pizza to {Nazwa} jej rodzaj to {Rodzaj}, cena to {Cena}");   
    }
    
}
class Dostawa
{
    public string RodzajDostawy { get; set;}
    public int Odleglosc {get; set;}
    public int CenaKm {get; set;}

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
    public string Nazwa { get; set;}
    public int Cena {get; set;}
    public int Ilosc{get; set;}

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
        // This line prints "Hello, World" 
        Console.WriteLine("Hello, World");
        Pizza pizza1 = new Pizza("Margherita", "Wegetariańska", "25 zł");
        pizza1.PizzaInfo();

        // TODO
        // menu wyboru pizzy, prosi o wybór pizzy, wybór dodatków i dostawy, a potem podsumowanie
        // funkcja która przy wyborze dowozu prosi o podanie odległości.
        Dostawa dostawa1 = new Dostawa("Dowóz", 10, 2);
        Dostawa dostawa2 = new Dostawa("Na miejscu", 0, 0);
        Dostawa dostawa3 = new Dostawa("Odbiór osobisty", 0, 0);
        
        dostawa1.DostawaInfo();
        dostawa2.DostawaInfo();
        dostawa3.DostawaInfo();


    }
}

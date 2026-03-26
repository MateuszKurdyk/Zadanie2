using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
namespace Zadanie2;
//klasy
//klasa pizza 
//  nazwa, rodzaj, cena
//klasa dostawa
//  rodzaj dostawy, ilosc km, cena za km
//klasa dodatki
//  nazwa, cena, ilosc

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
        Console.WriteLine($"Wyvrany rodzaj dostawy to {RodzajDostawy}, odleglosc to {Odleglosc} km, cena za km to {CenaKm} zł");
    }
}
class Program
{
    static void Main()
    {

        // This line prints "Hello, World" 
        Console.WriteLine("Hello, World");
    }
}

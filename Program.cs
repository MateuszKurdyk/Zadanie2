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
    public void PizzaInfo()
    {
        Console.WriteLine($"Wybrana pizza to {Nazwa} jej rodzaj to {Rodzaj}, cena to {Cena}");   
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

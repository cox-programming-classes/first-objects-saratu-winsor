using System.Runtime.InteropServices.ComTypes;
using FirstObjects_2024;

Console.WriteLine("Let's Play Cards!");

Deck deck = new();
foreach (var card in deck)
{
    Console.WriteLine(card);
}

var cards = deck.Deal(5).ToList();
Console.WriteLine("I dealt some cards");

foreach (var card in cards)
{
    Console.WriteLine(card);
}

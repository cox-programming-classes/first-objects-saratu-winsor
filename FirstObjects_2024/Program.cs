using System.Runtime.InteropServices.ComTypes;
using FirstObjects_2024;


Console.WriteLine("Let's Play BlackJack!");
Deck deck = new();
deck.Shuffle();

Player dealer = new(), player = new();
dealer.Hit(deck.DealOne());
player.Hit(deck.DealOne());
dealer.Hit(deck.DealOne());
player.Hit(deck.DealOne());

Console.WriteLine($"Player: {player}");
while (!player.DidStand)
{
    if (dealer.Score < 18)
        dealer.Hit(deck.DealOne());
    else dealer.Stand();
    
    Console.WriteLine("Hit or Stand?");
    var response = Console.ReadLine()!.ToUpperInvariant();

    if (response.StartsWith("H"))
        player.Hit(deck.DealOne());
    else if (response.StartsWith("S"))
        player.Stand();
    else
        Console.WriteLine("what ??");
}

while (!dealer.DidStand)
{
    if (dealer.Score < 18)
        dealer.Hit(deck.DealOne());
    else dealer.Stand();
}

Console.WriteLine($"Player: {player}");
Console.WriteLine($"Dealer: {dealer}");
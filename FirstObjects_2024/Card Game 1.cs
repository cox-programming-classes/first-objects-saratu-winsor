namespace FirstObjects_2024;

public class Card_Game_1
{
    private Hand _hand = new();
    private Hand dealerHand = new Hand();
}

public void InsertRandomly(IEnumerable<Card> cards) //putting this is was the only way for my InsertRandomly in the Shuffle method to not be red but I lowkey don't know why
{
        
}


public void Shuffle()
{
    (var pile1, var pile2) = Split(); //why is split red?

    InsertRandomly(pile1);
    InsertRandomly(pile2);
        
}

public IEnumerable<Card> Deal(int 2)
{
    for (var i = 0; i < 2; i++)
        yield return DealOne(); //why is dealone red?
}

public int GetValue() //get the value of the hand after dealing
{
    while (Value < 21) //i dont think this is right...
    {
        
    }
}


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

//calculate scores when everyone stands (whoever is closest to 21 without going over wins)
//player chooses if ace is 1 or 11 unless it being 11 would get them over 21




//if (dealer.Score == 21)
    //Console.WriteLine("Dealer Wins!");

//if (player.Score = 21)
    //Console.WriteLine("Player Wins!");    
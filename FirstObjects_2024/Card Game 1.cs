namespace FirstObjects_2024;

public class Card_Game_1
{
    private Hand playerHand = new Hand();
    private Hand dealerHand = new Hand():
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
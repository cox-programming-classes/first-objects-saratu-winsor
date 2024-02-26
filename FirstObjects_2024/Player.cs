namespace FirstObjects_2024;

/// <summary>
/// Represents a player in a game of Blackjack
/// </summary>
public class Player
{
  private Hand _hand = new();


  public bool DidStand { get; private set; } = false;

  public int Score
  {
    get
    {
      var total = 0;
      foreach (var card in _hand)
        total += card.Value;

      return total;
    }
  }

  public void Hit(Card card) => _hand.Add(card);
  public void Stand() => DidStand = true;

  public void Reset()
  {
    _hand = new();
    DidStand = false;
  }

  public override string ToString() => $"{_hand} => {Score}";

}
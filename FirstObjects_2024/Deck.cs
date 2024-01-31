using System.Net.Security;

namespace FirstObjects_2024;

/// <summary>
/// Represents a standard set of playing cards
/// </summary>


public class Deck : IEnumerable<Card>
{
    private List<Card> _cards;

    public Deck()
    {
        _cards = [];
        foreach (var suit in Suit.AllSuits)
        {
            foreach (var value in Value.AceHighValues)
            {
                _cards.Add(new(suit, value));
            }
            

            #region Enumerable stuff
            public IEnumerator<Card> GetEnumerator()
            {
                return _cards.GetEnumerator();
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable)_cards).GetEnumerator();
            }
            #endregion //Enumerable stuff
    }       
        

}


using System.Collections;
using System.Data;
using System.Net.Security;

namespace FirstObjects_2024;


public class Deck : IEnumerable<Card>
{
    

    private List<Card> _cards;
    /// <summary>
    /// Are there any cards left in the deck?
    /// </summary>
    public bool IsEmpty => _cards.Count == 0;
    
    /// <summary>
    /// Initialize a new deck of cards
    /// </summary>
    public Deck() //constructor method (contructs objects, special method !!), generating the cards
    {
        this._cards = new();
        foreach (var suit in Suit.AllSuits)
            foreach (var value in Value.AceHighValues)
                _cards.Add(new(suit, value));
    } 

    /// <summary>
    /// Deal the First Card from this Deck
    /// </summary>
    /// <returns>The Top Card</returns>
    /// <exception cref="InvalidOperationException">When the Deck is Empty</exception cref
    public Card DealOne()
    {
        if (_cards.Count == 0)
            throw new InvalidOperationException("Deck is Empty!!");
        var card = _cards.First();
        _cards.RemoveAt(0); // if you don't remove it, you're making a copy
        return card;
    }
/// <summary>
/// deal n cards from the deck, be sure to cast this as a concrete type immediately otherwise cards will be deleted
/// </summary>
/// <param name="n"> n = number of cards to return </param>
/// <returns></returns>
    public IEnumerable<Card> Deal(int n)
    {
        for (var i = 0; i < n; i++)
            yield return DealOne();
    }

    /// <summary>
    /// Insert a single card at the bottom of the deck 
    /// </summary>
    /// <param name="card">The card to add.</param>
    public void AddToBottom(Card card) => _cards.Add(card);

    /// <summary>
    /// Add a collection of cards to the bottom of the deck
    /// </summary>
    /// <param name="card">The card to add.</param>
    public void AddToBottom(IEnumerable<Card> cards) => _cards.AddRange(cards);
    
    /// <summary>
    /// Using the Random Number Generator
    /// interest the card randomly into the current list of Cards
    /// </summary>
    /// <param name="card">The card to be inserted.</param>
    // public void InsertRandomly(Card card){...}
    
    /// <summary>
    /// Using the Random Number Generator
    /// </summary>
    /// <param name="cards">The cards to be inserted.</param>
    //public void InsertRandomly(IEnumerable<Card> cards)
    
    /// <summary>
    /// Shuffle the Deck of Cards
    /// TODO: Describe your algorithm here
    /// </summary>
    //public void Shuffle(){...}
    #region Enumerable Stuff
    public IEnumerator<Card> GetEnumerator()
    {
        return _cards.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)_cards).GetEnumerator();
    }
    #endregion //Enumerable Stuff
}


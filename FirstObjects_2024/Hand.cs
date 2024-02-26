using System.Collections;
using System.Net.Sockets;
using System.Reflection;

namespace FirstObjects_2024;

public class Hand : IEnumerable<Card>
{
    private readonly List<Card> _cards;
    private static readonly Random rand = new();

    public Hand()
    {
        _cards = new List<Card>();
    }

    public void Add(Card a)
    {
        _cards.Add(a);
    }

    public Card Take()
    {
        var card = _cards[0];
        _cards.RemoveAt(0);
        return card;
    }

    public Card TakeRandomly()
    {
        var n = rand.Next(_cards.Count);
        var card = _cards[n];
        _cards.RemoveAt(n);
        return card;
    }

    public bool Has(Suit s) => _cards.Any(card => card.Suit == s);

    public bool Has(Value s) => _cards.Any(card => card.Value == s);

    public bool Has(Card s) => _cards.Any(card => card == s);


    public IEnumerator<Card> GetEnumerator()
    {
        return _cards.GetEnumerator();
    }

    public override string ToString() =>
        _cards
            .Select(card => $"{card}")
            .Aggregate((a, b) => $"{a}, {b}");

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)_cards).GetEnumerator();
    }

}



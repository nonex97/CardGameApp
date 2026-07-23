using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }

    public abstract class Deck
    {
        public void CreateDeck()
        {
            
        }

        public virtual void ShuffleDeck()
        {

        }

        public abstract List<PlayingCard> DealCard(); // we don't know how to deal cards, but we know every game needs to deal cards

        public virtual PlayingCard RequestCard()
        {

        }

    }

    public class PlayingCard
    {
        public CardSuit Suit { get; set; }
        public CardValue Value { get; set; }
    }

    public enum CardValue
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public enum CardSuit
    {
        Hearts,
        Clubs,
        Diamonds,
        Spades
    }
}

using System;
using System.Collections.Generic;

namespace CodingAssessment_Syniti
{
    public class DeckOfCard
    {
        public enum Suit
        {
            Hearts,
            Spades,
            Clubs,
            Diamonds
        }

        public enum FaceValue
        {
            Ace = 1,
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

        public class Card
        {
            public Suit Suit { get; set; }
            public FaceValue FaceValue { get; set; }

            public Card(Suit suit, FaceValue faceValue)
            {
                Suit = suit;
                FaceValue = faceValue;
            }

            public override string ToString()
            {
                return $"{FaceValue} of {Suit}";
            }
        }

        public class Deck
        {
            private List<Card> _cards = new List<Card>();
            private Random _random = new Random();

            public Deck()
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    foreach (FaceValue faceValue in Enum.GetValues(typeof(FaceValue)))
                    {
                        _cards.Add(new Card(suit, faceValue));
                    }
                }
            }

            public void Shuffle()
            {
                for (int i = _cards.Count - 1; i > 0; i--)
                {
                    int j = _random.Next(i + 1);
                    Card temp = _cards[i];
                    _cards[i] = _cards[j];
                    _cards[j] = temp;
                }
            }

            public Card DealOneCard()
            {
                if (_cards.Count > 0)
                {
                    Card card = _cards[0];
                    _cards.RemoveAt(0);
                    return card;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}

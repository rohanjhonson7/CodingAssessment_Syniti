using static CodingAssessment_Syniti.DeckOfCard;

class Program
{
    static void Main(string[] args)
    {
        Deck deck = new Deck();
        deck.Shuffle();

        for (int i = 0; i < 53; i++)
        {
            Card card = deck.DealOneCard();
            if (card == null)
            {
                Console.WriteLine("No more cards in the deck.");
            }
            else
            {
                Console.WriteLine(card);
            }
        }

    }
}
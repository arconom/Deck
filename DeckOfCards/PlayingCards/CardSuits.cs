using System.Collections.Generic;

namespace DeckOfCards.PlayingCards
{
    /// <summary>
    /// This is a static list of the suits in a standard 52 card deck, with sort values included.
    /// </summary>
    /// <seealso cref="System.Collections.Generic.List{DeckOfCards.PlayingCards.PlayingCardSuit}" />
    public class PlayingCardSuits : List<PlayingCardSuit>
    {
        /// <summary>
        /// This is a static list of the suits in a standard 52 card deck, with sort values included.
        /// </summary>
        private static readonly PlayingCardSuits _default = new PlayingCardSuits
        {
            new PlayingCardSuit('C', "Clubs", 1),
            new PlayingCardSuit('D', "Diamonds", 2),
            new PlayingCardSuit('H', "Hearts", 3),
            new PlayingCardSuit('S', "Spades", 4)
        };

        public static PlayingCardSuits Default()
        {
            return _default;
        }
    }
}
using System;

namespace DeckOfCards.PlayingCards
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.IComparable{DeckOfCards.PlayingCards.PlayingCardSuit}" />
    public class PlayingCardSuit : IComparable<PlayingCardSuit>
    {
        #region Properties

        public char Code { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }

        #region IComparable<CardSuit> Members

        public int CompareTo(PlayingCardSuit other)
        {
            if (Order > other.Order) return 1;
            if (Order == other.Order) return 0;
            return -1;
        }

        #endregion IComparable<CardSuit> Members

        #endregion Properties

        public PlayingCardSuit(char code, string name, int order)
        {
            Code = code;
            Name = name;
            Order = order;
        }

        #region Methods

        /// <summary>
        /// Returns a card without a suit.
        /// </summary>
        /// <returns></returns>
        public static PlayingCardSuit NoSuit()
        {
            return new PlayingCardSuit('N', "None", 100);
        }

        /// <summary>
        /// Returns a joker suit.
        /// </summary>
        /// <returns></returns>
        public static PlayingCardSuit Joker()
        {
            return new PlayingCardSuit('J', "Joker", 100);
        }

        #endregion Methods
    }
}
using System;

namespace DeckOfCards.PlayingCards
{
    /// <summary>
    /// This class represents a standard playing card of a specified rank.
    /// </summary>
    /// <seealso cref="System.IComparable{DeckOfCards.PlayingCards.PlayingCardRank}" />
    public class PlayingCardRank : IComparable<PlayingCardRank>
    {
        #region Properties

        //This is the shorthand method for denoting a rank: A23456789TJQK
        public char Id { get; set; }

        //This is the long form of the rank
        public string Name { get; set; }

        //This determines in which order the card will be sorted.
        public int Order { get; set; }

        #region IComparable<CardIdentity> Members

        public int CompareTo(PlayingCardRank other)
        {
            if (Order > other.Order) return 1;
            if (Order == other.Order) return 0;
            return -1;
        }

        #endregion IComparable<CardIdentity> Members

        #endregion Properties

        public PlayingCardRank(char id, string name, int order)
        {
            Id = id;
            Name = name;
            Order = order;
        }

        #region Methods

        /// <summary>
        /// Returns a joker.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static PlayingCardRank Joker()
        {
            //W is for wild
            return new PlayingCardRank('W', "Joker", 100);
        }

        /// <summary>
        /// Returns a card without a rank.
        /// </summary>
        /// <returns></returns>
        public static PlayingCardRank Unknown()
        {
            return new PlayingCardRank('N', "None", 100);
        }

        #endregion Methods
    }
}
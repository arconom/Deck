using System;

namespace DeckOfCards.PlayingCards
{
    public class PlayingCard : ICard, IComparable
    {
        #region Properties

        public PlayingCardSuit Suit { get; set; }
        public PlayingCardRank Identity { get; set; }

        #region ICard Members

        /// <summary>
        ///     Gets the description, consisting of the unabbreviated rank and suit.
        /// </summary>
        /// <value>The description.</value>
        public string Description
        {
            get { return Identity.Name + " of " + Suit.Name; }
        }

        /// <summary>
        /// Gets or sets the foreign key that relates to a deck.
        /// </summary>
        /// <value>
        /// The deck id.
        /// </value>
        public Guid FKDeckId { get; set; }

        /// <summary>
        /// Gets or sets the sort order.
        /// </summary>
        /// <value>
        /// The sort order.
        /// </value>
        public int Order { get; set; }

        /// <summary>
        /// Get the concatenated card rank and suit, which serves as an identifier within the context of a classical playing card.
        /// </summary>
        /// <value>The card code.</value>
        public string Id
        {
            get { return string.Concat(Identity.Id, Suit.Code); }
        }

        #endregion ICard Members

        #region IComparable

        public int CompareTo(object other)
        {
            if (other is PlayingCard)
            {
                return CompareTo((PlayingCard)other);
            }
            else return -1;
        }

        public int CompareTo(PlayingCard other)
        {
            if (Suit.Order > other.Suit.Order)
            {
                return 1;
            }
            else if (Suit.Order == other.Suit.Order)
            {
                if (Identity.Order > other.Identity.Order)
                {
                    return 1;
                }
                else if (Identity.Order == other.Identity.Order)
                {
                    return 0;
                }
                else if (Identity.Order < other.Identity.Order)
                {
                    return -1;
                }
            }
            else if (Suit.Order < other.Suit.Order)
            {
                return -1;
            }

            return -1;
        }

        #endregion IComparable

        #endregion Properties

        public PlayingCard(PlayingCardSuit cardSuit, PlayingCardRank cardIdentity, Guid deckId)
        {
            Suit = cardSuit;
            Identity = cardIdentity;
            FKDeckId = deckId;
        }

        #region Methods

        /// <summary>
        ///     Determines whether the specified <see cref = "System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name = "obj">The <see cref = "System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///     <c>true</c> if the specified <see cref = "System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref = "T:System.NullReferenceException">
        ///     The <paramref name = "obj" /> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            return obj is PlayingCard ? ((PlayingCard)obj).Id == Id : false;
        }

        /// <summary>
        ///     Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        ///     A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        /// <summary>
        ///     Generates a card from the specified code.
        /// </summary>
        /// <param name = "id">The id.</param>
        /// <returns></returns>
        /// <summary>
        ///     Returns a <see cref = "System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        ///     A <see cref = "System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var result = Id + " - " + Identity.Name + " - " + Description;
            return result;
        }

        /// <summary>
        ///     Determines whether card is from the specified deck.
        /// </summary>
        /// <param name = "deckId">The deck id.</param>
        /// <returns>
        ///     <c>true</c> if is from deck otherwise, <c>false</c>.
        /// </returns>
        public bool IsFromDeck(Guid deckId)
        {
            return FKDeckId == deckId;
        }

        /// <summary>
        /// Generate a card without a suit or rank.
        /// </summary>
        /// <returns></returns>
        public static PlayingCard UnknownCard()
        {
            return new PlayingCard(PlayingCardSuit.NoSuit(), PlayingCardRank.Unknown(), Guid.Empty);
        }

        /// <summary>
        /// Generate a joker.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="deckId">The deck identifier.</param>
        /// <returns></returns>
        public static PlayingCard Joker(int number, Guid deckId)
        {
            return new PlayingCard(PlayingCardSuit.Joker(), PlayingCardRank.Joker(), deckId);
        }

        #endregion Methods
    }
}
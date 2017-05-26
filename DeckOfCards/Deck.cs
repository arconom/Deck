using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckOfCards
{
    /// <summary>
    /// This class contains the basic ops that any deck of cards should have.
    /// Shuffle
    /// Get single card
    /// Get card list
    /// </summary>
    /// <typeparam name="TCard">The type of the card.</typeparam>
    /// <seealso cref="System.Collections.Generic.List{TCard}" />
    public abstract class Deck<TCard> : List<TCard> where TCard : ICard
    {
        #region properties

        public Guid Id { get; private set; }

        #endregion properties

        protected Deck()
        {
            Id = Guid.NewGuid();
        }

        #region methods

        /// <summary>
        /// Shuffles this deck instance.
        /// Uses the lambda and LINQ method that the kids are so excited about these days.
        /// Not sure about the efficiency of this.
        /// Seems like it should be linear.
        /// </summary>
        public void Shuffle()
        {
            Random r = new Random();

            List<TCard> temp = this.OrderBy(a => r.Next()).ToList();

            this.Clear();
            this.AddRange(temp);
        }

        /// <summary>
        /// This is the Fisher Yates implementation.
        /// It runs in linear time, which is about as good as you can expect for randomisation
        /// </summary>
        public void FisherYatesShuffle()
        {
            var rand = new Random();
            for (var i = Count - 1; i > 0; i--)
            {
                var n = rand.Next(i + 1);
                var temp = this[i];
                this[i] = this[n];
                this[n] = temp;
            }
        }

        /// <summary>
        /// Returns a card from the specified code.
        /// </summary>
        /// <param name = "code">The card id.</param>
        /// <returns></returns>
        public TCard Card(string code)
        {
            var r = this.SingleOrDefault(x => x.Id == code);

            if (r == null) throw new Exception("Invalid card id, did not recognise: " + code);

            return r;
        }

        /// <summary>
        /// Gets a list of cards from a list of card codes
        /// </summary>
        /// <param name = "cardCodes">The card ids.</param>
        /// <returns></returns>
        public List<TCard> Cards(string[] cardCodes)
        {
            return cardCodes.Select(Card).ToList();
        }

        #endregion methods
    }
}
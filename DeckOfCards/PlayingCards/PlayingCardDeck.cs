using System.Collections.Generic;
using System.Linq;

namespace DeckOfCards.PlayingCards
{
    public class PlayingCardDeck : Deck<PlayingCard>
    {
        public PlayingCardDeck()
        {
            Initialize(PlayingCardSuits.Default(), PlayingCardIdentities.AceLow(), 0);
        }

        /// <summary>
        ///     Initializes the deck, creates cards, adds jokers etc.
        /// </summary>
        /// <param name = "suits">The suits.</param>
        /// <param name = "identities">The numbers.</param>
        /// <param name = "numberOfJokers">The number of jokers.</param>
        private void Initialize(PlayingCardSuits suits, PlayingCardIdentities identities, int numberOfJokers)
        {
            foreach (var cardSuit in suits)
                foreach (var cardNumber in identities)
                    Add(new PlayingCard(cardSuit, cardNumber, Id));

            for (var i = 0; i < numberOfJokers; i++)
                Add(PlayingCard.Joker(i, Id));
        }

        /// <summary>
        ///     Gets a card by suit and number.
        /// </summary>
        /// <param name = "number">The number.</param>
        /// <param name = "suit">The suit.</param>
        /// <returns></returns>
        public PlayingCard Card(int number, PlayingCardSuit suit)
        {
            return this.FirstOrDefault(x => x.Identity.Order == number && x.Suit == suit);
        }

        /// <summary>
        ///     Gets all cards from a specified suit
        /// </summary>
        /// <param name = "suit">The suit.</param>
        /// <returns></returns>
        public List<PlayingCard> SuitCards(PlayingCardSuit suit)
        {
            return Enumerable.Range(1, 12).Select(x => Card(x, suit)).ToList();
        }
    }
}
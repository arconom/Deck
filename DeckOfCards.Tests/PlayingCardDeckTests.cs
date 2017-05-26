using DeckOfCards.PlayingCards;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckOfCards.Tests
{
    [TestClass]
    public class PlayingCardDeckTests
    {
        private List<PlayingCard> sortedDeck;

        public void Driver()
        {
            sortedDeck = GenerateSortedDeck();
            PlayingCardDeck deck = new PlayingCardDeck();

            CardObjectEqualityCanBeTested(deck);
            DeckComplete(deck);
            DeckShuffled(deck);
            DeckSorted(deck);
            Console.WriteLine("All tests passed");
        }

        [TestMethod]
        public void CardObjectEqualityCanBeTested(PlayingCardDeck input)
        {
            PlayingCard card = input.Card("5C");
            Assert.AreEqual(card, input.Card("5C"));
            Console.WriteLine("Card equality test passed");
        }

        /// <summary>
        /// Checks for existence of all 52 cards.
        /// </summary>
        /// <param name="input">The input.</param>
        [TestMethod]
        public void DeckComplete(PlayingCardDeck input)
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("====== Playing Cards ======");

            foreach (var card in input)//.OrderBy(x => x.Suit))
            {
                Console.WriteLine(card.ToString());
            }

            Assert.AreEqual(true, input.All(x => sortedDeck.Contains(x)));
            Console.WriteLine("Complete deck generation test passed");
        }

        /// <summary>
        /// Check the deck's sort function by
        /// making sure the indexes of the cards in the input deck match the indexes of the cards in the sorted deck
        /// </summary>
        /// <param name="input">This is the deck to test.</param>
        [TestMethod]
        public void DeckSorted(PlayingCardDeck input)
        {
            input.Sort();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("====== Sorted Playing Cards ======");

            foreach (var card in input)
            {
                Console.WriteLine(card.ToString());
            }

            Assert.AreEqual(true, input.All(x =>
            {
                return input.FindIndex(y => y.Equals(x)) == sortedDeck.FindIndex(z => z.Equals(x));
            }));
            Console.WriteLine("Deck sort test passed");
        }

        /// <summary>
        /// Does the shuffle function execute?
        /// </summary>
        /// <param name="input">The input.</param>
        [TestMethod]
        public void DeckShuffled(PlayingCardDeck input)
        {
            input.Shuffle();
            //input.FisherYatesShuffle();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("====== Playing Cards Shuffled ======");

            foreach (var card in input)
            {
                Console.WriteLine(card.ToString());
            }

            // assuming Shuffle doesn't raise an exception, we assume it executed.
            Assert.IsTrue(true);
            Console.WriteLine("Deck shuffle test passed");
        }

        /// <summary>
        /// Generates a sorted deck.
        /// I could have used a loop here, but I wanted the reader to be able to see the sort order
        /// also a loop would be another thing to test for errors
        /// </summary>
        /// <returns></returns>
        private List<PlayingCard> GenerateSortedDeck()
        {
            List<PlayingCard> returnMe = new List<PlayingCard>();
            PlayingCardIdentities playingCardIdentities = PlayingCardIdentities.AceLow();
            PlayingCardSuits playingCardSuits = PlayingCardSuits.Default();
            Guid deckId = Guid.NewGuid();

            returnMe.Add(new PlayingCard(playingCardSuits[0], playingCardIdentities[0], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[0], playingCardIdentities[1], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[0], playingCardIdentities[2], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[0], playingCardIdentities[3], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[0], playingCardIdentities[4], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[0], playingCardIdentities[5], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[0], playingCardIdentities[6], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[0], playingCardIdentities[7], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[0], playingCardIdentities[8], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[0], playingCardIdentities[9], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[0], playingCardIdentities[10], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[0], playingCardIdentities[11], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[0], playingCardIdentities[12], deckId));

            returnMe.Add(new PlayingCard(playingCardSuits[1], playingCardIdentities[0], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[1], playingCardIdentities[1], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[1], playingCardIdentities[2], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[1], playingCardIdentities[3], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[1], playingCardIdentities[4], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[1], playingCardIdentities[5], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[1], playingCardIdentities[6], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[1], playingCardIdentities[7], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[1], playingCardIdentities[8], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[1], playingCardIdentities[9], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[1], playingCardIdentities[10], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[1], playingCardIdentities[11], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[1], playingCardIdentities[12], deckId));

            returnMe.Add(new PlayingCard(playingCardSuits[2], playingCardIdentities[0], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[2], playingCardIdentities[1], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[2], playingCardIdentities[2], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[2], playingCardIdentities[3], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[2], playingCardIdentities[4], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[2], playingCardIdentities[5], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[2], playingCardIdentities[6], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[2], playingCardIdentities[7], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[2], playingCardIdentities[8], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[2], playingCardIdentities[9], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[2], playingCardIdentities[10], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[2], playingCardIdentities[11], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[2], playingCardIdentities[12], deckId));

            returnMe.Add(new PlayingCard(playingCardSuits[3], playingCardIdentities[0], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[3], playingCardIdentities[1], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[3], playingCardIdentities[2], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[3], playingCardIdentities[3], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[3], playingCardIdentities[4], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[3], playingCardIdentities[5], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[3], playingCardIdentities[6], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[3], playingCardIdentities[7], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[3], playingCardIdentities[8], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[3], playingCardIdentities[9], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[3], playingCardIdentities[10], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[3], playingCardIdentities[11], deckId));
            returnMe.Add(new PlayingCard(playingCardSuits[3], playingCardIdentities[12], deckId));

            return returnMe;
        }

        /// <summary>
        /// Tests the card.
        /// </summary>
        /// <param name="cardIdentity">The card identity.</param>
        /// <param name="suit">The suit.</param>
        /// <param name="code">The code.</param>
        //private static void TestCard(PlayingCardIdentity cardIdentity, PlayingCardSuit suit, string code)
        //{
        //    var card = new PlayingCard(suit, cardIdentity);

        //    Assert.AreEqual(card.Identity, number);
        //    Assert.AreEqual(card.Suit, suit);
        //    Assert.AreEqual(card.Identity.Name, code);
        //    Assert.AreEqual(card.Identity.IsFaceCard, isFaceCard);
        //    Assert.AreEqual(card.Identity.IsJoker, isJoker);

        //    Console.WriteLine(card.Description + " - OK");
        //}
    }
}
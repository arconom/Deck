using DeckOfCards.HappyFamilies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeckOfCards.Tests
{
    [TestClass]
    public class HappyFamiliesTests
    {
        [TestMethod]
        public void CardObjectEqualityCanBeTested()
        {
            var deck = new HappyFamiliesDeck();
            var card = deck.Card("MrBun");

            Assert.AreEqual(card, deck.Card("MrBun"));
        }
    }
}
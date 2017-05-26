using DeckOfCards.PlayingCards;
using System;
using System.Linq;
using DeckOfCards.Tests;

namespace DeckOfCards.TestConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PlayingCardDeckTests playingCardDeckTests = new PlayingCardDeckTests();
            playingCardDeckTests.Driver();

            Console.ReadKey();
        }
    }
}
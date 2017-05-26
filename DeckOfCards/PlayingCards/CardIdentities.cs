using System.Collections.Generic;

namespace DeckOfCards.PlayingCards
{
    public class PlayingCardIdentities : List<PlayingCardRank>
    {
        public static PlayingCardIdentities AceLow()
        {
            return new PlayingCardIdentities
            {
                new PlayingCardRank('A', "Ace", 1),
                new PlayingCardRank('2', "Two", 2),
                new PlayingCardRank('3', "Three", 3),
                new PlayingCardRank('4', "Four", 4),
                new PlayingCardRank('5', "Five", 5),
                new PlayingCardRank('6', "Six", 6),
                new PlayingCardRank('7', "Seven", 7),
                new PlayingCardRank('8', "Eight", 8),
                new PlayingCardRank('9', "Nine", 9),
                new PlayingCardRank('T', "Ten", 10),
                new PlayingCardRank('J', "Jack", 11),
                new PlayingCardRank('Q', "Queen", 12),
                new PlayingCardRank('K', "King", 13),
            };
        }
    }
}
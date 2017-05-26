using System;

namespace DeckOfCards.HappyFamilies
{
    public class HappyFamiliesDeck : DeckBase<HappyFamiliesCard>
    {
        public HappyFamiliesDeck()
        {
            Initialize();
        }

        /// <summary>
        ///     Initializes the deck, creates cards
        /// </summary>
        private void Initialize()
        {
            foreach (var family in CardFamily.ToList())
                foreach (var value in Enum.GetNames(typeof (CardTitle)))
                    Add(new HappyFamiliesCard(family, (CardTitle) Enum.Parse(typeof (CardTitle), value), DeckId));
        }
    }
}
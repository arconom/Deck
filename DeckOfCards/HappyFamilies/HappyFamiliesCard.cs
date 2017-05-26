using System;

namespace DeckOfCards.HappyFamilies
{
    public class HappyFamiliesCard : ICard
    {
        public HappyFamiliesCard(CardFamily cardFamily, CardTitle cardTitle, Guid deckId)
        {
            CardFamily = cardFamily;
            CardTitle = cardTitle;
            FromDeckId = deckId;
            Code = cardTitle + cardFamily.Name;
        }

        public CardFamily CardFamily { get; set; }
        public CardTitle CardTitle { get; set; }

        #region ICard Members

        public string Code { get; private set; }
        public Guid FromDeckId { get; set; }
        public ICardSet AssignedTo { get; set; }
        public int StackOrder { get; set; }

        public string Description
        {
            get
            {
                var result = string.Format("{0} {1} the {2}", CardTitle, CardFamily.Name, CardFamily.Profession);

                switch (CardTitle)
                {
                    case CardTitle.Mrs:
                        return result + "'s Wife";
                    case CardTitle.Master:
                        return result + "'s Son";
                    case CardTitle.Miss:
                        return result + "'s Daughter";
                    default:
                        return result;
                }
            }
        }

        #endregion
    }
}
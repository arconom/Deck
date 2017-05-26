using System;

namespace DeckOfCards.TestConsole
{
    internal class Hand : ICardSet
    {
        private Guid _setId;

        #region ICardSet Members

        public Guid CardSetId
        {
            get
            {
                if (_setId == Guid.Empty) _setId = Guid.NewGuid();
                return _setId;
            }
        }

        public int ItemCount
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}
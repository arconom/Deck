using System;

namespace DeckOfCards
{
    /// <summary>
    ///     Interface defining a card set
    /// </summary>
    public interface ICardSet
    {
        Guid CardSetId { get; }
        int ItemCount { get; }
    }
}
using System;

namespace DeckOfCards
{
    /// <summary>
    /// The ICard interface defines characteristics that are common to all cards
    /// The deck to which the card belongs
    /// An id
    /// A sort order
    /// A Description
    /// </summary>
    public interface ICard
    {
        string Id { get; }
        Guid FKDeckId { get; set; }
        int Order { get; set; }
        string Description { get; }
    }
}
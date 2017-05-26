using System.Collections.Generic;

namespace DeckOfCards.HappyFamilies
{
    public enum CardTitle
    {
        Mr,
        Mrs,
        Master,
        Miss
    }

    public class CardFamily
    {
        public static readonly CardFamily Bun = new CardFamily("Bun", "Baker");
        public static readonly CardFamily Block = new CardFamily("Block", "Barber");
        public static readonly CardFamily Bones = new CardFamily("Bones", "Butcher");
        public static readonly CardFamily Bung = new CardFamily("Bung", "Brewer");
        public static readonly CardFamily Chip = new CardFamily("Chip", "Carpenter");
        public static readonly CardFamily Dose = new CardFamily("Dose", "Doctor");

        public CardFamily(string name, string profession)
        {
            Name = name;
            Profession = profession;
        }

        public string Name { get; set; }
        public string Profession { get; set; }

        public static List<CardFamily> ToList()
        {
            return new List<CardFamily> {Bun, Block, Bones, Bung, Chip, Dose};
        }
    }
}
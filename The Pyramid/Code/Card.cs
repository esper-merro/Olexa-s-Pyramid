using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Pyramid
{
    public enum Deck
    {
            IsaacRuns,
            IsaacModifiers,
    }
    public abstract class Card
    {
        public IsaacRuns(string CardName, string CardPath)
            : base(CardName, CardPath) {
            public int CardID { get; protected set; }
            public Deck DeckID { get; protected set; }
            public string CardText { get; protected set; }
            public bool CardUnlocked;
            public bool CardAvailable;
    }
        public Card(string CardName, string CardPath) { }
    }
}

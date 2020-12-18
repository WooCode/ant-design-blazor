using Ardalis.SmartEnum;

namespace Append.AntDesign.Components
{
    public sealed class CardType : SmartEnum<CardType>
    {
        public static readonly CardType Default = new CardType(nameof(Default).ToLower(), 1);
        public static readonly CardType Small = new CardType(nameof(Small).ToLower(), 2);

        private CardType(string name, int value) : base(name, value)
        {
        }
    }
}

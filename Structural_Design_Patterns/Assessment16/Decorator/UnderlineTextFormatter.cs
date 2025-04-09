using Assessment16.Contacts;

namespace Assessment16.Decorator
{
    internal class UnderlineTextFormatter : BaseTextFormatterDecorator
    {
        public UnderlineTextFormatter(ITextFormatter textFormatter) : base(textFormatter)
        {
        }

        public override string Format(string text)
        {
            return _textFormatter.Format($"[UNDERLINED] {text}");
        }
    }
}

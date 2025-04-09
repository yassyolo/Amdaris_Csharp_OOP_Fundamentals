using Assessment16.Contacts;

namespace Assessment16.Decorator
{
    internal class BoldTextFormatter : BaseTextFormatterDecorator
    {
        public BoldTextFormatter(ITextFormatter textFormatter) : base(textFormatter)
        {
        }

        public override string Format(string text)
        {
            return _textFormatter.Format($"[BOLD] {text}");
        }
    }
}

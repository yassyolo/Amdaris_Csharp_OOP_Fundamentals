using Assessment16.Contacts;

namespace Assessment16.Decorator
{
    internal class ItalicTextFormatter : BaseTextFormatterDecorator
    {
        public ItalicTextFormatter(ITextFormatter textFormatter) : base(textFormatter)
        {
        }

        public override string Format(string text)
        {
            return _textFormatter.Format($"[ITALIC] {text}");
        }
    }
}

using Assessment16.Contacts;

namespace Assessment16.Decorator
{
    internal class ColorTextFormatter : BaseTextFormatterDecorator
    {
        private readonly string _color;
        public ColorTextFormatter(ITextFormatter textFormatter, string color) : base(textFormatter)
        {
            _color = color;
        }

        public override string Format(string text)
        {
            return _textFormatter.Format($"[COLOR({_color})] {text}");
        }
    }
}

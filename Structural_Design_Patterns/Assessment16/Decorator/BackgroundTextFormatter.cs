using Assessment16.Contacts;

namespace Assessment16.Decorator
{
    internal class BackgroundTextFormatter : BaseTextFormatterDecorator
    {
        private readonly string _color;
        public BackgroundTextFormatter(ITextFormatter textFormatter, string color) : base(textFormatter)
        {
            _color = color;
        }

        public override string Format(string text)
        {
            return _textFormatter.Format($"[BACKGROUND({_color})] {text}");
        }
    }
}

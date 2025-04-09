using Assessment16.Contacts;

namespace Assessment16.Decorator
{
    internal abstract class BaseTextFormatterDecorator
    {
        protected ITextFormatter _textFormatter;

        public BaseTextFormatterDecorator(ITextFormatter textFormatter)
        {
            _textFormatter = textFormatter;
        }

        public abstract string Format(string text);
    }
}

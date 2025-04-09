using Assessment16.Contacts;

namespace Assessment16.Implementations
{
    internal class PlainTextFormat : ITextFormatter
    {
        public string Format(string text)
        {
            return text;
        }
    }
}

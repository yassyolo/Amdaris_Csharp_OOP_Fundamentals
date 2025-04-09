using Assessment16.Contacts;
using Assessment16.Decorator;
using Assessment16.Implementations;
using System.Runtime.Serialization;

namespace Assessment16
{
    internal class FormatManager
    {
        private readonly string _inputText;
        private readonly Stack<BaseTextFormatterDecorator> _textFormatters = new();

        public FormatManager(string inputText)
        {
            _inputText = inputText;
        }

        public void AddTextFormatter(BaseTextFormatterDecorator textFormatter)
        {
            _textFormatters.Push(textFormatter);
        }

        public void RemoveTextFormatter()
        {
            if (_textFormatters.Count > 0)
            {
                _textFormatters.Pop();
            }
        }

        public string FormatText()
        {
            string formattedText = _inputText;

            foreach (var formatter in _textFormatters)
            {
                formattedText = formatter.Format(formattedText);
            }

            return formattedText;            
        }
    }
}

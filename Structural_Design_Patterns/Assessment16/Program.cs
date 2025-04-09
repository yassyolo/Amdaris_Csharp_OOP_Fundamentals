using Assessment16;
using Assessment16.Contacts;
using Assessment16.Decorator;
using Assessment16.Implementations;

ITextFormatter textFormatter = new PlainTextFormat();
BaseTextFormatterDecorator colorTextFormatter = new ColorTextFormatter(textFormatter, "pink");
BaseTextFormatterDecorator underlineTextFormatter = new UnderlineTextFormatter(textFormatter);
BaseTextFormatterDecorator boldTextFormatter = new BoldTextFormatter(textFormatter);
BaseTextFormatterDecorator italicTextFormatter = new ItalicTextFormatter(textFormatter);
BaseTextFormatterDecorator backgroundFormatter = new BackgroundTextFormatter(textFormatter, "blue");

var manager = new FormatManager("Hello World!");

manager.AddTextFormatter(boldTextFormatter);
manager.AddTextFormatter(italicTextFormatter);
manager.AddTextFormatter(colorTextFormatter);
manager.AddTextFormatter(underlineTextFormatter);
manager.AddTextFormatter(backgroundFormatter);

Console.WriteLine(manager.FormatText());

manager.RemoveTextFormatter();

Console.WriteLine(manager.FormatText());

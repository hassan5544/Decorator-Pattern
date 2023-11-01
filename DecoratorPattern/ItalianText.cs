namespace DecoratorPattern;

public class ItalianText : IText
{
    private readonly IText _text;

    public ItalianText(IText text)
    {
        _text = text;
    }
    public void GetText(string text)
    {
        text += "Italic Text ";
        _text.GetText(text);
    }
}
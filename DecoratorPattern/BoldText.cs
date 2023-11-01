namespace DecoratorPattern;

public class BoldText : IText
{
    private readonly IText _text;

    public BoldText(IText text)
    {
        _text = text;
    }
    public void GetText(string text)
    {
        text += "Bold Text ";
        _text.GetText(text);
    }
}
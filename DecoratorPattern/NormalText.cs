namespace DecoratorPattern;

public class NormalText : IText
{
    public void GetText(string text)
    {
        Console.WriteLine(text);
    }
}
using DecoratorPattern;

class Program
{
    public static void Main()
    {
        string test = "testing ";

        IText text = new NormalText();
        
        text.GetText(test);

        IText textBold = new BoldText(text);
        textBold.GetText(test);
        
        
        IText textItalic = new ItalianText(text);

        textItalic.GetText(test);
        
        
    }
}
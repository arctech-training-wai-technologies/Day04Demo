class Button
{
    public int Left, Top;
    public char Text;

    public void Create(int left, int top, char text)
    {
        Left = left;
        Top = top;
        Text = text;
    }

    public void SetColor(ConsoleColor foregroundColor, ConsoleColor backgroundColor)
    {
        Console.ForegroundColor = foregroundColor;
        Console.BackgroundColor = backgroundColor;
    }

    public void Show()
    {
        Console.SetCursorPosition(Left, Top);
        Console.Write("     ");
        Console.SetCursorPosition(Left, Top + 1);
        Console.Write($"  {Text}  ");
        Console.SetCursorPosition(Left, Top + 2);
        Console.Write("     ");
    }
}
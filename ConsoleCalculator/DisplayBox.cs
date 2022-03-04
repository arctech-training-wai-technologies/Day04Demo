class DisplayBox
{
    public int Left, Top;
    public int Width;

    public void Create(int left, int top, int width)
    {
        Left = left;
        Top = top;
        Width = width;
    }

    public void SetColor(ConsoleColor foregroundColor, ConsoleColor backgroundColor)
    {
        Console.ForegroundColor = foregroundColor;
        Console.BackgroundColor = backgroundColor;
    }

    public void Show()
    {
        var s = new string(' ', Width);

        Console.SetCursorPosition(Left, Top);
        Console.WriteLine(s);
        Console.SetCursorPosition(Left, Top + 1);
        Console.WriteLine(s);
        Console.SetCursorPosition(Left, Top + 2);
        Console.WriteLine(s);
    }
}
class Calculator
{
    DisplayBox displayBox;
    Button buttonPercent, buttonClearEverything, buttonClear, buttonBack;
    Button buttonReciprocal, buttonSquare;
    private Button button1;
    private Button button2;
    private Button buttonPlus;

    private MathsKeyHandler handler;

    public void Start()
    {
        DisplayBackground();
        ShowDisplayBox();
        ShowAllButtons();

        // What is this for
        //Console.ReadKey();
        handler = new MathsKeyHandler();
        handler.StartCheckingKeys(displayBox);
    }

    private void DisplayBackground()
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Blue;

        var s = new string(' ', 31);

        for (int row = 2; row <= 25; row++)
        {
            Console.SetCursorPosition(17, row);
            Console.Write(s);
        }

        Console.SetCursorPosition(19, 3);
        Console.Write("WAI IT CALCULATOR");

        Console.ResetColor();
    }

    private Button CreateAButton(int left, int top, string text)
    {
        var button = new Button();

        button.Create(left, top, text);
        button.SetColor(ConsoleColor.White, ConsoleColor.Magenta);
        button.Show();

        return button;
    }

    private void ShowAllButtons()
    {
        buttonPercent = CreateAButton(19, 9, "%");
        buttonClearEverything = CreateAButton (26, 9, "CE");
        buttonClear = CreateAButton(33, 9, "C");
        buttonBack = CreateAButton(40, 9, "<=");
        
        buttonReciprocal = CreateAButton(19, 13, "/x");
        buttonSquare = CreateAButton(26, 13, "x2");
        button1 = CreateAButton(33, 13, "1");
        button2 = CreateAButton(40, 13, "2");
        
        buttonPlus = CreateAButton(19, 17, "+");

        Console.ResetColor();
    }

    private void ShowDisplayBox()
    {
        displayBox = new DisplayBox();
        displayBox.Create(19, 5, 27, ConsoleColor.White, ConsoleColor.Cyan);
        displayBox.Show();
        displayBox.ShowText("");
        Console.ResetColor();
    }
}

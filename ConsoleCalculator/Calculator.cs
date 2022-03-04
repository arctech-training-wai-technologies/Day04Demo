// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
Q. What entities are needed?
A. Calculator
B. DisplayBox
C. Button
*/

class Calculator
{
    DisplayBox displayBox;
    Button buttonPercent, buttonClearEverything, buttonClear, buttonBack;
    Button buttonReciprocal, buttonSquare;

    public void Start()
    {
        DisplayBackground();
        ShowDisplayBox();
        ShowAllButtons();

        // What is this for
        Console.ReadKey();
    }

    private void DisplayBackground()
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Blue;

        var s = new string(' ', 32);

        for (int row = 2; row <= 15; row++)
        {
            Console.SetCursorPosition(17, row);
            Console.Write(s);
        }

        Console.SetCursorPosition(20, 3);
        Console.Write("WAI IT CALCULATOR");

        Console.ResetColor();
    }

    private Button CreateAButton(int left, int top, char text)
    {
        var button = new Button();

        button.Create(left, top, text);
        button.SetColor(ConsoleColor.White, ConsoleColor.Magenta);
        button.Show();

        return button;
    }

    private void ShowAllButtons()
    {
        buttonPercent = CreateAButton(20, 9, '%');
        buttonClearEverything = CreateAButton (27, 9, 'E');
        buttonClear = CreateAButton(34, 9, 'C');
        buttonBack = CreateAButton(41, 9, 'B');
        buttonReciprocal = CreateAButton(20, 13, 'R');
        buttonSquare = CreateAButton(27, 13, 'S');
        Console.ResetColor();
    }

    private void ShowDisplayBox()
    {
        displayBox = new DisplayBox();
        displayBox.Create(20, 5, 26);
        displayBox.SetColor(ConsoleColor.White, ConsoleColor.Cyan);
        displayBox.Show();
        Console.ResetColor();
    }
}

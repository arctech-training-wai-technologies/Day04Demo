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
        ShowDisplayBox();
        ShowAllButtons();
        Console.ReadKey();
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
        buttonPercent = CreateAButton(20, 6, '%');
        buttonClearEverything = CreateAButton (27, 6, 'E');
        buttonClear = CreateAButton(34, 6, 'C');
        buttonBack = CreateAButton(41, 6, 'B');
        buttonReciprocal = CreateAButton(20, 10, 'R');
        buttonSquare = CreateAButton(27, 10, 'S');
        Console.ResetColor();
    }

    private void ShowDisplayBox()
    {
        displayBox = new DisplayBox();
        displayBox.Create(20, 2, 26);
        displayBox.SetColor(ConsoleColor.White, ConsoleColor.Cyan);
        displayBox.Show();
        Console.ResetColor();
    }
}

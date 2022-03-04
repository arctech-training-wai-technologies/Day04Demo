internal class MathsKeyHandler
{
    string buffer = "";

    internal void StartCheckingKeys(DisplayBox displayBox)
    {
        ConsoleKeyInfo keyInfo;

        do
        {
            keyInfo = Console.ReadKey(true);    // Why is the purpose of true

            if (keyInfo.KeyChar >= '0' && keyInfo.KeyChar <= '9')
                NumberKeyPressed(keyInfo.KeyChar);
            else if (keyInfo.KeyChar == '.')
                DotKeyPressed();
            else if (keyInfo.Key == ConsoleKey.Backspace)
                BackSpacePressed();
            else
                continue;

            displayBox.ShowText(buffer);

        } while (keyInfo.Key != ConsoleKey.Escape);
    }

    private void NumberKeyPressed(char keyChar)
    {
        buffer += keyChar;
    }

    private void BackSpacePressed()
    {
        if (buffer != "")
            buffer = buffer.Substring(0, buffer.Length - 1);
        else
            Console.Write('\a');
    }

    private void DotKeyPressed()
    {
        if (buffer.Contains('.'))
            Console.Write('\a');
        else
            buffer += '.';        
    }
}
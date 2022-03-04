//Console.WriteLine("Hello, World!");

//Demo01Operators.TestDivision();
//Demo01Operators.TestIncrement();
//Demo01Operators.TestLogical();
//Demo01Operators.TestComparison();
//Demo01Operators.TestOthers();
//Demo01Operators.TestTernary();
//Demo01Operators.Test_New_TypeOf_Is();
Demo02BitWiseOperator.TestNot();
Demo02BitWiseOperator.TestOr();
Demo02BitWiseOperator.TestAnd();
Demo02BitWiseOperator.TestXor();

class Demo02BitWiseOperator
{
    internal static void TestXor()
    {
        // & operator

        uint ch1 = 'A';
        uint ch2 = 'Z';
        uint ans1 = ch1 ^ ch2;
        Console.WriteLine($"operator ^ => ch1 = {ch1}, ch2 = {ch2}, ans1 = {ans1}");

        // ch1 =  00000000 00000000 00000000 01000001 = 65 'A'
        // ch1 =  00000000 00000000 00000000 01011010 = 90 'Z'
        // ans1 = 00000000 00000000 00000000 00011011 = 27
    }

    internal static void TestAnd()
    {
        // & operator

        uint ch1 = 'A';
        uint ch2 = 'Z';
        uint ans1 = ch1 & ch2;
        Console.WriteLine($"operator & => ch1 = {ch1}, ch2 = {ch2}, ans1 = {ans1}");

        // ch1 =  00000000 00000000 00000000 01000001 = 65 'A'
        // ch1 =  00000000 00000000 00000000 01011010 = 90 'Z'
        // ans1 = 00000000 00000000 00000000 01000000 = 64
    }

    internal static void TestOr()
    {
        // & operator

        uint ch1 = 'A';
        uint ch2 = 'Z';
        uint ans1 = ch1 | ch2;
        Console.WriteLine($"operator | => ch1 = {ch1}, ch2 = {ch2}, ans1 = {ans1}");

        // ch1 =  00000000 00000000 00000000 01000001 = 65 'A'
        // ch1 =  00000000 00000000 00000000 01011010 = 90 'Z'
        // ans1 = 00000000 00000000 00000000 01011011 = 91
    }

    internal static void TestNot()
    {
        // ~ operator
        uint ch = 'A';
        uint newCh = ~ch;

        Console.WriteLine($"Before ~ => ascii value = {ch} and character = {(char)ch}");
        Console.WriteLine($"After ~ => ascii value = {newCh} and character = {(char)newCh}");

        // ch =  00000000 00000000 00000000 01000001 = 65
        // ~ch = 11111111 11111111 11111111 10111110 = 4,29,49,67,230
    }
}
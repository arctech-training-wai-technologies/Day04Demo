using System.Text;

class Demo01Operators
{
    internal static void Test_New_TypeOf_Is()
    {
        // new operator
        StringBuilder sb = new StringBuilder();
        var sb2 = new StringBuilder();

        //typeof operator, parameter = any other DataType (value type or reference type)
        Console.WriteLine(typeof(StringBuilder));
        Console.WriteLine(typeof(int));
        Console.WriteLine(typeof(string));
        Console.WriteLine(typeof(Console));

        //is operator
        if(sb is StringBuilder)
            Console.WriteLine("Yes this is a string builder");
        else
            Console.WriteLine("No this is not a string builder");
    }
    
    internal static void TestTernary()
    {
        int age = 18;
        
        // Do not use if...else, for simple conditional variable initialization
        int salary;
        if (age >= 18)
            salary = 10000;
        else
            salary = 999;

        // Better use ternary operator for above
        int salary2 = age >= 18 ? 10000 : 999;
    }

    internal static void TestOthers()
    {
        // + with string
        var firstName = "Raman";
        var lastName = "Gujral";
        var fullName = firstName + lastName;
        Console.WriteLine(fullName);

        // [] operator
        string[] names = { "apple", "mango", "pineapple" };
        Console.WriteLine(names[2]);

        // () operator
        var ans1 = 10 + 20 + 30 * 5 / 2;
        var ans2 = 10 + (20 + 30) * 5 / 2;
        Console.WriteLine(ans1);    // Expected ans = 105
        Console.WriteLine(ans2);    // Expected ans = 135

        // typecast operator (or cast operator) E.g., (datatype)
        char ch = (char)65;
        //string s = (string)101; // NO NO NO
        int ans3 = (int)100.99999;
    }

    internal static void TestComparison()
    {
        int a = 5;
        int b = 4;

        Console.WriteLine(a >= b);      //	True
        Console.WriteLine(a != b);      //	True
        Console.WriteLine(a == b);		//	False  
        Console.WriteLine(a == a);		//	True  
        Console.WriteLine(a != b++);	//	True
        Console.WriteLine(a > b);	    //	False

        int y = 10;
        y += 15;
    }

    internal static void TestLogical()
    {
        var a = true;
        var b = false;

        Console.WriteLine(a && b);              // FALSE
        Console.WriteLine(a || b);              // TRUE
        Console.WriteLine(a ^ b);               // TRUE
        Console.WriteLine(!b);                  // TRUE
        Console.WriteLine();
        Console.WriteLine(b || true);           // TRUE
        Console.WriteLine(b && true);           // FALSE
        Console.WriteLine(a || true);           // TRUE
        Console.WriteLine(a && true);           // TRUE
        Console.WriteLine();
        Console.WriteLine(!a);                  // FALSE
        Console.WriteLine((5 > 7) ^ (a == b));  // FALSE
    }

    internal static void TestIncrement()
    {
        int ans1 = 10;
        ////=> ans1 = 10

        int ans2 = ans1++;
        // Internal working of postfix ++
        //int ans2 = ans1;
        //ans1 = ans2 + 1; // ++

        ////=> ans2 = 10, ans1 = 11

        int ans3 = ++ans1;
        // Internal working of ++ prefix
        //ans1 = ans1 + 1;    // ++
        //int ans3 = ans1;

        ////=> ans3 = 12, ans1 = 12

        Console.WriteLine(ans1);    //12 //11, 10, 10, 10, 10, 10
        Console.WriteLine(ans2);    //10 //11, 10, 11, 11, 11, 10
        Console.WriteLine(ans3);    //12 //11, 11, 11, 10, 11, 12
    }

    internal static void TestDivision()
    {

        var ans1 = 11 / 3;
        int ans2 = 11 / 3;
        float ans3 = 11 / 3.0f;

        //float ans4 = 11 / 3.0;  
        // Not allowed?? Because 3.0 by default in C# in double
        // smaller can be stored automatically into larger
        // but larger cannot be stored into smaller automatically

        int denominator = 0;
        int numerator = 11;
        float ans5 = numerator / 0;

        Console.WriteLine(ans1);
        Console.WriteLine(ans2);
        Console.WriteLine(ans3);
    }
}
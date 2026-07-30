namespace OperatorsExpressionsPractices;

class Program
{
    static void Main(string[] args)
    {
        Exercise1();
         Console.WriteLine("\n--------------------\n");

        Exercise2();
         Console.WriteLine("\n--------------------\n");

        Exercise3();
         Console.WriteLine("\n--------------------\n");


        Exercise4();
         Console.WriteLine("\n--------------------\n");

        Exercise5();
         Console.WriteLine("\n--------------------\n");

        Exercise6();
         Console.WriteLine("\nDone! All exercises completed successfully.");

    }
//-------------------------------------
    /*
    Exercise 1 — Easy
    Problem:
    Declare two integer variables a = 10 and b = 4 . Print the result of adding, subtracting, multiplying,
    and dividing them (one result per line).
    Expected Input:
    None
    Expected Output:
    14
    6
    40
    2
    Solution (C#) :*/
static void Exercise1()
    {
        int a = 10; // a = 10
        int b = 4; // b = 4
        Console.WriteLine(a + b); // 14
        Console.WriteLine(a - b); // 6
        Console.WriteLine(a * b); // 40
        Console.WriteLine(a / b); // 2
    }
//--------------------------------------------
    /*
    Exercise 2 — Easy
    Problem:
    Declare an integer x = 17 . Print the remainder when x is divided by 5 .
    Expected Input:
    None
    Expected Output:
    2
    Solution (C#):
    */
static void Exercise2()
    {
        int a = 17; // a = 17
        Console.WriteLine(a % 5); // 2
    }

    //--------------------------------------------
    /*
    Exercise 3 — Medium
    Problem:
    Start with a variable score = 10 . Use compound assignment operators to:
    1. Add 5 to it
    2. Multiply it by 2
    3. Subtract 3 from it
    Print the final value.
    Expected Input:
    None
    Expected Output:
    27
    Solution (C#):
    */
static void Exercise3()
    {
        int score = 10; // score = 10
        score += 5;  // score = score + 5
        score *= 2;  // score = score * 2
        score -= 3;  // score = score - 3
        Console.WriteLine(score); // 27
    }

    //--------------------------------------------

    /*
    Exercise 4 — Medium
    Problem:
    Declare int a = 5 and int b = 10 . Using comparison operators, print whether a is less than b ,
    whether they are equal, and whether a is greater than or equal to b .
    Expected Input:
    None
    Expected Output:
    True
    False
    False
    Solution (C#):*/
static void Exercise4()
    {
        int a = 5; // a = 5
        int b = 10; // b = 10
        Console.WriteLine(a < b);   // True
        Console.WriteLine(a == b);  // False
        Console.WriteLine(a >= b);  // False
    }

    //--------------------------------------------

    /*
    Exercise 5 — Medium
    Problem:
    Declare bool isRaining = true and bool hasUmbrella = false . Use logical operators to print:
    1. Whether it is raining AND they have an umbrella
    2. Whether it is raining OR they have an umbrella
    3. Whether it is NOT raining
    Expected Input:
    None
    Expected Output:
    False
    True
    False
    Solution (C#):*/
static void Exercise5()
    {
        bool isRaining = true; // isRaining = true
        bool hasUmbrella = false; // hasUmbrella = false

        Console.WriteLine(isRaining && hasUmbrella); // False
        Console.WriteLine(isRaining || hasUmbrella); // True
        Console.WriteLine(!isRaining);                // False
    }

    //--------------------------------------------

    /*
    Exercise 6 — Hard
    Problem:
    You have a variable counter = 1 . Use increment and decrement operators and consider operator
    precedence carefully. Print counter after a pre-increment, then print the result of using counter in the
    expression counter++ + 5 (think: does counter increment before or after the expression is
    evaluated?). Finally print counter again to see its new state.
    Expected Input:
    None
    Expected Output:
    2
    7
    3
    Solution (C#):
*/
static void Exercise6()
    {
        int counter = 1; // counter = 1

        Console.WriteLine(++counter); // Pre-increment: counter becomes 2, then printed
        Console.WriteLine(counter++ + 5); // Post-increment: 2 + 5 = 7, then counter becomes 3
        Console.WriteLine(counter); // Now counter is 3
    }
    
}

<div align="center">

# 🎯 C# Operators & Expressions
### Practice Exercises — Fully Documented Solutions

**Course:** C# Fundamentals And The Language Core
**Platform:** Metigator
**Instructor:** Essam Abdelnabi (عصام عبدالنبي)
**Module:** 05 · Operators & Expressions

</div>

---

## 📚 Course Progress

| # | Module | Status |
|:-:|--------|:------:|
| 01 | Introduction | ✅ |
| 02 | .NET Setup & Tooling | ✅ |
| 03 | Explore Your First .NET Project | ✅ |
| 04 | Variables & Data Types | ✅ |
| 05 | **Operators & Expressions** | ✅ *(this document)* |

> These exercises apply everything taught in **Module 05 — Operators & Expressions**: arithmetic, compound assignment, comparison, logical, and increment/decrement operators — built on top of the variable and data-type foundations from Module 04.

---

## 🗂️ Table of Contents

| Exercise | Topic | Difficulty |
|:--------:|-------|:----------:|
| [1](#exercise-1--easy) | Arithmetic Operators | 🟢 Easy |
| [2](#exercise-2--easy) | Modulus Operator | 🟢 Easy |
| [3](#exercise-3--medium) | Compound Assignment | 🟡 Medium |
| [4](#exercise-4--medium) | Comparison Operators | 🟡 Medium |
| [5](#exercise-5--medium) | Logical Operators | 🟡 Medium |
| [6](#exercise-6--hard) | Increment/Decrement & Precedence | 🔴 Hard |
| — | [Full Program](#-full-program) | — |
| — | [Key Concepts Recap](#-key-concepts-recap) | — |

**Namespace:** `Exercise` &nbsp;·&nbsp; **Class:** `Program`

Every solution below is fully documented with inline comments explaining *what* each line does and *why* it produces the expected output — no black boxes.

---

## Exercise 1 — 🟢 Easy

**Topic:** Arithmetic Operators (`+`, `-`, `*`, `/`)

**Problem:**
Declare two integer variables `a = 10` and `b = 4`. Print the result of adding, subtracting, multiplying, and dividing them (one result per line).

**Expected Input:** None

**Expected Output:**
```
14
6
40
2
```

**Solution (C#):**
```csharp
static void Exercise1()
{
    int a = 10; // a = 10
    int b = 4;  // b = 4

    Console.WriteLine(a + b); // Addition: 10 + 4 = 14
    Console.WriteLine(a - b); // Subtraction: 10 - 4 = 6
    Console.WriteLine(a * b); // Multiplication: 10 * 4 = 40
    Console.WriteLine(a / b); // Integer division: 10 / 4 = 2 (fractional part discarded)
}
```

💡 **Note:** Since both `a` and `b` are `int`, the division truncates the decimal part instead of rounding — this is *integer division*, not floating-point division.

---

## Exercise 2 — 🟢 Easy

**Topic:** Modulus Operator (`%`)

**Problem:**
Declare an integer `x = 17`. Print the remainder when `x` is divided by `5`.

**Expected Input:** None

**Expected Output:**
```
2
```

**Solution (C#):**
```csharp
static void Exercise2()
{
    int a = 17; // a = 17

    Console.WriteLine(a % 5); // Modulus: 17 ÷ 5 = 3 remainder 2 → prints 2
}
```

💡 **Note:** `%` returns the *remainder* of a division, not a percentage — a common beginner mix-up.

---

## Exercise 3 — 🟡 Medium

**Topic:** Compound Assignment Operators (`+=`, `*=`, `-=`)

**Problem:**
Start with a variable `score = 10`. Use compound assignment operators to:
1. Add 5 to it
2. Multiply it by 2
3. Subtract 3 from it

Print the final value.

**Expected Input:** None

**Expected Output:**
```
27
```

**Solution (C#):**
```csharp
static void Exercise3()
{
    int score = 10; // score = 10

    score += 5;  // score = score + 5  → 15
    score *= 2;  // score = score * 2  → 30
    score -= 3;  // score = score - 3  → 27

    Console.WriteLine(score); // 27
}
```

💡 **Note:** Compound operators evaluate left to right, in the order they're written — each one updates `score` before the next one runs.

---

## Exercise 4 — 🟡 Medium

**Topic:** Comparison Operators (`<`, `==`, `>=`)

**Problem:**
Declare `int a = 5` and `int b = 10`. Using comparison operators, print whether `a` is less than `b`, whether they are equal, and whether `a` is greater than or equal to `b`.

**Expected Input:** None

**Expected Output:**
```
True
False
False
```

**Solution (C#):**
```csharp
static void Exercise4()
{
    int a = 5;  // a = 5
    int b = 10; // b = 10

    Console.WriteLine(a < b);   // Is 5 < 10?  → True
    Console.WriteLine(a == b);  // Is 5 == 10? → False
    Console.WriteLine(a >= b);  // Is 5 >= 10? → False
}
```

💡 **Note:** Comparison operators always return a `bool` (`True`/`False`) and never modify the operands — they only evaluate a relationship between them.

---

## Exercise 5 — 🟡 Medium

**Topic:** Logical Operators (`&&`, `||`, `!`)

**Problem:**
Declare `bool isRaining = true` and `bool hasUmbrella = false`. Use logical operators to print:
1. Whether it is raining AND they have an umbrella
2. Whether it is raining OR they have an umbrella
3. Whether it is NOT raining

**Expected Input:** None

**Expected Output:**
```
False
True
False
```

**Solution (C#):**
```csharp
static void Exercise5()
{
    bool isRaining = true;    // isRaining = true
    bool hasUmbrella = false; // hasUmbrella = false

    Console.WriteLine(isRaining && hasUmbrella); // true AND false → False
    Console.WriteLine(isRaining || hasUmbrella); // true OR false  → True
    Console.WriteLine(!isRaining);                // NOT true       → False
}
```

💡 **Note:** `&&` and `||` are *short-circuit* operators — `&&` stops evaluating as soon as it finds `False`, and `||` stops as soon as it finds `True`.

---

## Exercise 6 — 🔴 Hard

**Topic:** Increment/Decrement Operators & Operator Precedence (`++`)

**Problem:**
You have a variable `counter = 1`. Use increment and decrement operators and consider operator precedence carefully. Print `counter` after a pre-increment, then print the result of using `counter` in the expression `counter++ + 5` (think: does `counter` increment before or after the expression is evaluated?). Finally print `counter` again to see its new state.

**Expected Input:** None

**Expected Output:**
```
2
7
3
```

**Solution (C#):**
```csharp
static void Exercise6()
{
    int counter = 1; // counter = 1

    Console.WriteLine(++counter);       // Pre-increment: counter → 2 first, then printed → 2
    Console.WriteLine(counter++ + 5);   // Post-increment: current value (2) used first → 2 + 5 = 7, THEN counter → 3
    Console.WriteLine(counter);         // counter now holds its latest value → 3
}
```

💡 **Note:** This is the classic prefix vs. postfix trap:
- **Prefix (`++counter`)** → increments *first*, then returns the new value.
- **Postfix (`counter++`)** → returns the *current* value first, then increments.

---

## 🧩 Full Program

```csharp
namespace Exercise;

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
    Declare two integer variables a = 10 and b = 4. Print the result of adding, subtracting,
    multiplying, and dividing them (one result per line).
    Expected Output:
    14
    6
    40
    2
    */
    static void Exercise1()
    {
        int a = 10; // a = 10
        int b = 4;  // b = 4
        Console.WriteLine(a + b); // 14
        Console.WriteLine(a - b); // 6
        Console.WriteLine(a * b); // 40
        Console.WriteLine(a / b); // 2
    }

    //--------------------------------------------
    /*
    Exercise 2 — Easy
    Problem:
    Declare an integer x = 17. Print the remainder when x is divided by 5.
    Expected Output:
    2
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
    Start with a variable score = 10. Use compound assignment operators to:
    1. Add 5 to it
    2. Multiply it by 2
    3. Subtract 3 from it
    Print the final value.
    Expected Output:
    27
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
    Declare int a = 5 and int b = 10. Using comparison operators, print whether a is less than b,
    whether they are equal, and whether a is greater than or equal to b.
    Expected Output:
    True
    False
    False
    */
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
    Declare bool isRaining = true and bool hasUmbrella = false. Use logical operators to print:
    1. Whether it is raining AND they have an umbrella
    2. Whether it is raining OR they have an umbrella
    3. Whether it is NOT raining
    Expected Output:
    False
    True
    False
    */
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
    You have a variable counter = 1. Use increment and decrement operators and consider operator
    precedence carefully. Print counter after a pre-increment, then print the result of using
    counter in the expression counter++ + 5. Finally print counter again to see its new state.
    Expected Output:
    2
    7
    3
    */
    static void Exercise6()
    {
        int counter = 1; // counter = 1

        Console.WriteLine(++counter); // Pre-increment: counter becomes 2, then printed
        Console.WriteLine(counter++ + 5); // Post-increment: 2 + 5 = 7, then counter becomes 3
        Console.WriteLine(counter); // Now counter is 3
    }
}
```

---

## 🔑 Key Concepts Recap

| Category | Operators | Key Rule |
|----------|-----------|----------|
| **Arithmetic** | `+` `-` `*` `/` `%` | Result type depends on operand types; `int / int` discards the fractional part |
| **Assignment** | `=` `+=` `-=` `*=` `/=` | Right side is evaluated first, then assigned; compound operators simplify updates |
| **Comparison** | `<` `>` `<=` `>=` `==` `!=` | Always returns `bool`; never modifies the operands |
| **Logical** | `&&` `\|\|` `!` | `&&`/`\|\|` short-circuit; only `bool` operands allowed |
| **Increment/Decrement** | `++` `--` | Prefix increments *then* returns; postfix returns *then* increments |

### ⚠️ Common Mistakes to Avoid
- Using `int` division when a decimal result is actually expected.
- Confusing `=` (assignment) with `==` (equality comparison).
- Assuming `%` calculates a percentage — it returns a remainder.
- Mixing up prefix (`++x`) and postfix (`x++`) behavior inside expressions.
- Writing complex expressions without parentheses, relying purely on precedence.

---

<div align="center">

*Part of the <b>C# Fundamentals And The Language Core</b> course series — Metigator, by Essam Abdelnabi*

</div>

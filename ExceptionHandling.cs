

// ============================================================================
//                         EXCEPTION HANDLING
// ============================================================================

















// Prerequisites:

// What is an Exception?
// An exception is an error that occurs during the execution of a program,

// What is it Exception handling?
// Exception handling is a mechanism that allows you to handle runtime errors gracefully,
// preventing the program from crashing and providing meaningful feedback to the user.

// When we use it:
// We use it when we have risky code that might throw an exception, such as user input,
// file operations, or network requests.


// The diffrence:
// Runtime error الكود صحيح من ناحية الـ السنتاكس والبرنامج اشتغل، لكن أثناء التشغيل حصلت مشكلة

// Compile-time error الكود نفسه غلط والبرنامج مش هيشتغل





// ============================================================================
// 1. WHAT HAPPENS WITHOUT EXCEPTION HANDLING?
// ============================================================================

/*

Console.Write(
    "Enter your age: "
);


int age = Convert.ToInt32(
    Console.ReadLine()
);


Console.WriteLine(
    "Your age is: " + age
);

*/









// ============================================================================
// 2. BASIC TRY / CATCH
// ============================================================================

/*

try
{
    Console.Write(
        "Enter your age: "
    );


    int age = Convert.ToInt32(
        Console.ReadLine()
    );


    Console.WriteLine(
        "Your age is: " + age
    );
}
catch
{
    Console.WriteLine(
        "Something went wrong!"
    );
}

*/









// ============================================================================
// 3. FORMAT EXCEPTION
// ============================================================================

/*

try
{
    Console.Write(
        "Enter a number: "
    );


    int number = Convert.ToInt32(
        Console.ReadLine()
    );


    Console.WriteLine(
        "Number: " + number
    );
}
catch (FormatException)
{
    Console.WriteLine(
        "Invalid input!"
    );


    Console.WriteLine(
        "Please enter a valid number."
    );
}

*/









// ============================================================================
// 4. DIVIDE BY ZERO EXCEPTION
// ============================================================================

/*

try
{
    Console.Write(
        "Enter first number: "
    );


    int number1 = Convert.ToInt32(
        Console.ReadLine()
    );


    Console.Write(
        "Enter second number: "
    );


    int number2 = Convert.ToInt32(
        Console.ReadLine()
    );


    int result =
        number1 / number2;


    Console.WriteLine(
        "Result: " + result
    );
}
catch (DivideByZeroException)
{
    Console.WriteLine(
        "You cannot divide by zero!"
    );
}

*/









// ============================================================================
// 5. MULTIPLE CATCH BLOCKS
// ============================================================================

/*

try
{
    Console.Write(
        "Enter first number: "
    );


    int number1 = Convert.ToInt32(
        Console.ReadLine()
    );


    Console.Write(
        "Enter second number: "
    );


    int number2 = Convert.ToInt32(
        Console.ReadLine()
    );


    int result =
        number1 / number2;


    Console.WriteLine(
        "Result: " + result
    );
}


catch (FormatException)
{
    Console.WriteLine(
        "Please enter valid numbers!"
    );
}


catch (DivideByZeroException)
{
    Console.WriteLine(
        "You cannot divide by zero!"
    );
}

*/









// ============================================================================
// 6. EXCEPTION OBJECT
// ============================================================================

/*
try
{
    Console.Write(
        "Enter a number: "
    );


    int number =
        Convert.ToInt32(
            Console.ReadLine()
        );
}


catch (Exception ex)
{
    Console.WriteLine(
        "Error occurred!"
    );


    Console.WriteLine(
        ex.Message + "\n" + ex.StackTrace + "\n" + ex.GetType().Name);
}
*/







// ============================================================================
// 7. FINALLY
// ============================================================================

/*

try
{
    Console.Write(
        "Enter a number: "
    );


    int number =
        Convert.ToInt32(
            Console.ReadLine()
        );


    Console.WriteLine(
        "Number: " + number
    );
}


catch (FormatException)
{
    Console.WriteLine(
        "Invalid input!"
    );
}


finally
{
    Console.WriteLine(
        "This always runs."
    );
}
*/

// مش لازم كل
// try
// يكون معاه
// catch








// ============================================================================
// 8. THROWING AN EXCEPTION
// ============================================================================

/*

Console.Write(
    "Enter your age: "
);


int age =
    Convert.ToInt32(
        Console.ReadLine()
    );


if (age < 0)
{
    throw new Exception(
        "Age cannot be negative!"
    );
}


Console.WriteLine(
    "Your age is valid."
);

*/




// throw and threw new :
// throw new Exception("Age cannot be negative!"); // استخدمه لما أنت بنفسك تكتشف مشكلة وعايز تنشئ اكسبشن جديد
// throw // This rethrows the current exception, preserving the original stack trace.




// ============================================================================
// 9. THROW + TRY / CATCH
// ============================================================================

/*

try
{
    Console.Write(
        "Enter your age: "
    );


    int age =
        Convert.ToInt32(
            Console.ReadLine()
        );


    if (age < 0)
    {
        throw new Exception(
            "Age cannot be negative!"
        );
    }


    Console.WriteLine(
        "Your age is valid."
    );
}


catch (Exception ex)
{
    Console.WriteLine(
        ex.Message
    );
}

*/









// ============================================================================
// 10. EXCEPTION HANDLING WITH A FUNCTION
// ============================================================================

/*

int Divide(
    int number1,
    int number2
)
{
    if (number2 == 0)
    {
        throw new DivideByZeroException(
            "You cannot divide by zero!"
        );
    }


    return
        number1 / number2;
}


try
{
    int result =
        Divide(10, 0);


    Console.WriteLine(
        result
    );
}


catch (DivideByZeroException ex)
{
    Console.WriteLine(
        ex.Message
    );
}

*/









// ============================================================================
// 11. NESTED TRY / CATCH
// ============================================================================
//
// Not recommended for beginners in most cases.
// Only show if needed.
//



/*try
{
    Console.WriteLine(
        "Outer try"
    );

    try
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLi());
        int result = 10 / number;
        Console.WriteLine("Result: " + result);
    }


    catch (DivideByZeroException)
    {
        Console.WriteLine(
            "Inner exception handled!"
        );
    }
}


catch
{
    Console.WriteLine(
        "Outer exception handled!"
    );
}*/











// ============================================================================
// 12. PRACTICE
// ============================================================================
//  Impotrant Note : Exceptions are for exceptional situations, not normal validation.
//
//
// Create a program that:
//
// 1. Asks the user to enter two numbers.
//
// 2. Handles invalid input.
//
// 3. Handles division by zero.
//
// 4. Prints the result if everything is correct.
//
// 5. Another source if you want to watch https://youtu.be/mA1pOrYAHCU?si=YrFa-jwxN_nc-Lnw
// ============================================================================

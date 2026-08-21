// ============================================================================
//                         C# FUNCTIONS
// ============================================================================
//
// Uncomment ONE example at a time.
// ============================================================================







// ============================================================================
// 1. BASIC FUNCTION
// ============================================================================
//void main
//{

//}

//void SayHello()
//{
//    Console.WriteLine("Hello!");
//    Console.WriteLine("Hello!");
//    Console.WriteLine("Hello!");
//    Console.WriteLine("Hello!");
//    Console.WriteLine("Hello!");
//    Console.WriteLine("Hello!");
//}

//SayHello();
//SayHello();












// ============================================================================
// 2. FUNCTION WITH PARAMETER
// ============================================================================


//void SayHello(string name)
//{
//    Console.WriteLine("Hello " + name);
//}

//SayHello("Mahmoud");
//SayHello("Ali");
//SayHello("Ahmed");









// ============================================================================
// 3. MULTIPLE PARAMETERS
// ============================================================================

//void PrintUser(string name, int age, string email)
//{
//    Console.WriteLine("Name: " + name);
//    Console.WriteLine("Age: " + age);
//    Console.WriteLine("Email: " + email);
//    Console.WriteLine("\n");
//}

//PrintUser("Mahmoud", 20, "mahmoud@example.com");
//PrintUser("Ali", 25, "ali@example.com");
//PrintUser("Ahmed", 30, "ahmed@example.com");










// ============================================================================
// 4. RETURN VALUE
// ============================================================================


//int Add(int a, int b)
//{
//    int sum = a + b;
//    return sum;
//}

//int result = Add(10, 20);
//int result2 = Add(30, 40);
//int result3 = Add(50, 60);

//Console.WriteLine(result);
//Console.WriteLine(result2);
//Console.WriteLine(result3);









// ============================================================================
// 5. RETURN STRING
// ============================================================================


//string GetName(string name)
//{
//    return "welcome " + name;
//}

//string name = GetName("Mohamed");

//Console.WriteLine(name);









// ============================================================================
// 6. RETURN BOOL
// ============================================================================


//bool IsEven(int number)
//{
//    return (number % 2 == 0);
//}

//Console.WriteLine(IsEven(12));










// ============================================================================
// 7. FUNCTION WITH IF
// ============================================================================

//string GetGrade(int score)
//{
//    if (score >= 90)
//        return "A";

//    if (score >= 80)
//        return "B";

//    if (score >= 70)
//        return "C";

//    return "F";
//}

//Console.WriteLine(GetGrade(40));








// ============================================================================
// 8. FUNCTION WITH LOOP
// ============================================================================


//void PrintNumbers(int number)
//{
//    for (int i = 1; i <= number; i++)
//    {
//        Console.WriteLine(i);
//    }

//}

//PrintNumbers(1000);










// ============================================================================
// 9. FUNCTION WITH STRING
// ============================================================================

//int CountCharacters(string name)
//{
//    string Hello = "Hello " + name;
//    Console.WriteLine(Hello);
//    return Hello.Length;
//}

//Console.WriteLine(CountCharacters("Mahmoud"));










// ============================================================================
// 10. FUNCTION WITH ARRAY
// ============================================================================


//int GetSum(int[] numbers)
//{
//    int sum = 0;

//    foreach (int number in numbers)
//    {
//        sum += number;
//    }

//    return sum;
//}

//int[] numbers = { 10, 20, 30 };
//int[] numbers2 = {20, 10, 20, 30 , 40};

//Console.WriteLine(GetSum(numbers));
//Console.WriteLine(GetSum(numbers2));









// ============================================================================
// 11. FUNCTION CALLING ANOTHER FUNCTION
// ============================================================================


//int Add(int num1, int num2)
//{
//    return num1 + num2;
//}

//int Square(int num1, int num2)
//{
//    int Addition = Add(num1, num2);

//    int Multiply = num1 * num2;

//    return Addition + Multiply;
//}

//int result = Square(5, 10);

//Console.WriteLine(result);










// ============================================================================
// 12. MULTIPLE RETURNS
// ============================================================================

//string GetResult(int score)
//{
//    if (score >= 50)
//        return "Pass";

//    return "Fail";
//}

//Console.WriteLine(GetResult(30));









// ============================================================================
// 13. METHOD OVERLOADING
// ============================================================================

//int Add(int a, int b)
//{
//    return a + b;
//}

//int Add(int a, int b, int c)
//{
//    return a + b + c;
//}

//string Add(string a, string b)
//{
//    return a + b ;
//}

//Console.WriteLine(Add(10, 20));

//Console.WriteLine(Add("Welcome ", "Mahmoud"));









// ============================================================================
// 14. OPTIONAL PARAMETER
// ============================================================================


//void Greet(string name, string title = "Student")
//{
//    Console.WriteLine("Hello " + title + " " + name);
//}

//Greet("Mahmoud");

//Greet("Mahmoud", "Instructor");









// ============================================================================
// 15. NAMED ARGUMENT
// ============================================================================


//void PrintUser(string name, int age)
//{
//    Console.WriteLine(name);
//    Console.WriteLine(age);
//}

//PrintUser("Mahmoud", 20);
//PrintUser(age: 20, name: "Mahmoud");










// ============================================================================
// 16. params
// ============================================================================

//int Sum(string name, string koko ,params int[] numbers)
//{
//    int total = 0;

//    foreach (int number in numbers)
//    {
//        total += number;
//    }

//    return total;
//}

//Console.WriteLine(Sum("Alice", 1, 2, 3));

//Console.WriteLine(
//    Sum("Bob", 10, 20, 30, 40, 50, 60, 70)
//);









// ============================================================================
// 17. EXPRESSION-BODIED FUNCTION or  => LAMBDA FUNCTION
// ============================================================================

//int Square(int number) => number * number ;

//Console.WriteLine(
//    Square(5)
//);

//int Add(int a, int b)
//{
//    return a + b;
//}








// ============================================================================
// 18. PRACTICE
// ============================================================================
//
// Create a function that:
//
// 1. Prints "Welcome to C#"
//
// 2. Receives a name and prints:
//
//    Hello Mahmoud
//
// 3. Receives two numbers and returns their sum
//
// 4. Receives a number and returns true
//    if it is positive
//
// 5. Receives two numbers and returns
//    the larger number
//
// 6. Receives a price and discount percentage
//    and returns the final price
//
// ============================================================================
// ============================================================================
// 1. MEANINGFUL NAMES
// ============================================================================
//
// Use names that clearly describe what the variable represents.
//
// ============================================================================


int x = 20;

Console.WriteLine(x);










// ============================================================================
// 2. BETTER NAMES
// ============================================================================

/*
int studentAge = 20;

Console.WriteLine(studentAge);
*/









// ============================================================================
// 3. BOOLEAN NAMES
// ============================================================================

/*
bool isActive = true;
bool hasPermission = true;
bool canEdit = false;

Console.WriteLine(isActive);
Console.WriteLine(hasPermission);
Console.WriteLine(canEdit);
*/









// ============================================================================
// 4. CLEAN BOOLEAN CONDITION
// ============================================================================

/*
bool isActive = true;

if (isActive)
{
    Console.WriteLine("Active");
}
*/









// ============================================================================
// 5. MAGIC NUMBER
// ============================================================================

/*
int age = 20;

if (age >= 18)
{
    Console.WriteLine("Adult");
}
*/









// ============================================================================
// 6. CONSTANT
// ============================================================================

/*
const int MinimumAdultAge = 18;

int age = 20;

if (age >= MinimumAdultAge)
{
    Console.WriteLine("Adult");
}
*/









// ============================================================================
// 7. BAD FUNCTION NAME
// ============================================================================

/*
int Process(int x, int y)
{
    return x + y;
}

Console.WriteLine(
    Process(10, 20)
);
*/









// ============================================================================
// 8. GOOD FUNCTION NAME
// ============================================================================

/*
int CalculateSum(
    int firstNumber,
    int secondNumber)
{
    return firstNumber + secondNumber;
}

Console.WriteLine(
    CalculateSum(10, 20)
);
*/









// ============================================================================
// 9. SINGLE RESPONSIBILITY
// ============================================================================

/*
void ProcessStudent()
{
    // Get student
    // Validate student
    // Calculate grade
    // Save student
}
*/









// ============================================================================
// 10. SPLIT RESPONSIBILITIES
// ============================================================================

/*
void GetStudent()
{
}


void ValidateStudent()
{
}


void CalculateGrade()
{
}


void SaveStudent()
{
}
*/









// ============================================================================
// 11. DUPLICATE CODE
// ============================================================================

/*
double price1 = 100;
double tax1 = price1 * 0.14;


double price2 = 200;
double tax2 = price2 * 0.14;
*/









// ============================================================================
// 12. AVOID DUPLICATION
// ============================================================================

/*
const double TaxRate = 0.14;


double CalculateTax(double price)
{
    return price * TaxRate;
}


double tax1 = CalculateTax(100);
double tax2 = CalculateTax(200);

Console.WriteLine(tax1);
Console.WriteLine(tax2);
*/









// ============================================================================
// 13. DEEP NESTING
// ============================================================================

/*
bool isLoggedIn = true;
bool isActive = true;
bool hasPermission = true;


if (isLoggedIn)
{
    if (isActive)
    {
        if (hasPermission)
        {
            Console.WriteLine("Access granted");
        }
    }
}
*/









// ============================================================================
// 14. SIMPLER CONDITION
// ============================================================================

/*
bool isLoggedIn = true;
bool isActive = true;
bool hasPermission = true;


if (isLoggedIn && isActive && hasPermission)
{
    Console.WriteLine("Access granted");
}
*/









// ============================================================================
// 15. EARLY RETURN
// ============================================================================

/*
void CheckAccess(
    bool isLoggedIn,
    bool isActive,
    bool hasPermission)
{
    if (!isLoggedIn)
        return;

    if (!isActive)
        return;

    if (!hasPermission)
        return;

    Console.WriteLine("Access granted");
}


CheckAccess(true, true, true);
*/









// ============================================================================
// 16. UNNECESSARY COMMENT
// ============================================================================

/*
int age = 20;

// Add one to age
age++;
*/









// ============================================================================
// 17. USEFUL COMMENT
// ============================================================================

/*
 // We use the old pricing rule for legacy customers.
ApplyLegacyPricing();
*/









// ============================================================================
// 18. FORMATTING
// ============================================================================

/*
if (age >= 18) { Console.WriteLine("Adult"); }
*/









// ============================================================================
// 19. CLEAN FORMATTING
// ============================================================================

/*
if (age >= 18)
{
    Console.WriteLine("Adult");
}
*/









// ============================================================================
// 20. BEFORE AND AFTER
// ============================================================================

/*
void Process(int x, int y, bool z)
{
    int a = x + y;

    if (z == true)
    {
        if (a > 100)
        {
            Console.WriteLine(
                "The result is greater than 100"
            );
        }
    }
}
*/









// ============================================================================
// 21. CLEAN VERSION
// ============================================================================

/*
int CalculateTotal(
    int firstNumber,
    int secondNumber)
{
    return firstNumber + secondNumber;
}


bool IsLargeResult(int result)
{
    return result > 100;
}


void PrintResult(
    int result,
    bool isActive)
{
    if (!isActive)
        return;

    if (IsLargeResult(result))
    {
        Console.WriteLine(
            "The result is greater than 100"
        );
    }
}


int total = CalculateTotal(10, 100);

PrintResult(total, true);
*/









// ============================================================================
// 22. FINAL PRACTICE
// ============================================================================
//
// Refactor the following code.
//
// Don't change what the program does.
// Improve only the code quality.
//
// ============================================================================

/*
void Process(string n, int a, double g, bool s)
{
    if (s == true)
    {
        if (a >= 18)
        {
            if (g >= 60)
            {
                Console.WriteLine(n + " passed");
            }
            else
            {
                Console.WriteLine(n + " failed");
            }
        }
    }
}
*/
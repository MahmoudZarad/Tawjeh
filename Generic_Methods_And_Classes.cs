/*

    ============================================================
        C# - GENERIC METHODS & CLASSES
    ============================================================

    TOPICS COVERED:

    GENERICS BASICS
    - What Are Generics?
    - Why Use Generics?
    - Generic Methods
    - Generic Type Parameters
    - Calling Generic Methods
    - Type Inference
    - Multiple Type Parameters
    - Generic Methods with Return Values
    - Generic Methods with Arrays
    - Generic Methods with Lists

    GENERIC CLASSES
    - What Are Generic Classes?
    - Generic Class<T>
    - Creating Objects from Generic Classes
    - Generic Classes with Multiple Type Parameters
    - Generic Properties and Methods
    - Generic Stack Example

    GENERIC CONSTRAINTS
    - What Are Constraints?
    - where T : IComparable<T>
    - CompareTo()
    - Finding the Maximum Value
    - Sorting and Comparing Objects
    - where T : new()
    - Creating Objects Inside a Generic Class

    IMPORTANT DIFFERENCES
    - Generic vs Non-Generic Methods
    - Generic Method vs Generic Class
    - Type Inference vs Explicit Type Arguments
    - Constraints vs Regular Type Parameters
*/


// ============================================================
// PART 1 - GENERICS BASICS
// ============================================================



// 1. A Method Without Generics

/*PrintInt(100);
PrintString("Mahmoud");

void PrintInt(int value)
{
    Console.WriteLine(value);
}

void PrintString(string value)
{
    Console.WriteLine(value);
}*/

// Key Point:
// Without generics, we may need separate methods
// for different data types.





// 2. A Generic Method

//Print(100);
//Print("Mahmoud");
//Print(10.5);
//Print(true);

//void Print<T>(T value)
//{
//    //T age = value;
//    Console.WriteLine(value);
//}

// Key Point:
// T represents a type chosen when the method is called.
// One method can work with different data types.




/*
    // 3. Calling a Generic Method Explicitly

    Print<int>(100);
    Print<string>("Hello");
    Print<double>(15.5);

    void Print<T>(T value)
    {
        Console.WriteLine(value);
    }

    // Key Point:
    // You can specify the type argument explicitly.
*/



/*
    // 4. Type Inference

    Print(100);
    Print("Hello");
    Print(true);

    void Print<T>(T value)
    {
        Console.WriteLine(value);
    }

    // Key Point:
    // The compiler can infer T from the supplied argument.
*/




// 5. Generic Method with a Return Value

/*int number = GetValue<int>(100);
string name = GetValue<string>("Mahmoud");

Console.WriteLine(number);
Console.WriteLine(name);

T GetValue<T>(T value)
{
    return value;
}*/

// Key Point:
// A generic method can return the same type it receives.





// 6. Generic Method with Two Parameters

/*PrintPair<int, string>(10, "Mahmoud");
PrintPair("Age", 20);

void PrintPair<TFirst, TSecond>(TFirst first, TSecond second)
{
    Console.WriteLine($"{first} - {second}");
}
*/
// Key Point:
// A generic method can use multiple type parameters.





// 7. Generic Method with an Array

/*int[] numbers = { 10, 20, 30 };
string[] names = { "Ali", "Mona", "Omar" };

PrintArray(numbers);
PrintArray(names);

void PrintArray<T>(T[] items)
{
    foreach (T item in items)
    {
        Console.WriteLine(item);
    }
}*/

// Key Point:
// The same generic method can process arrays of different types.




/*
    // 8. Generic Method with a List

    List<int> numbers = new List<int> { 1, 2, 3 };
    List<string> names = new List<string> { "Ali", "Mona" };

    PrintList(numbers);
    PrintList(names);

    void PrintList<T>(List<T> items)
    {
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }

    // Key Point:
    // T represents the element type stored in the list.




// ============================================================
// PART 2 - GENERIC METHODS IN REAL EXAMPLES
// ============================================================


/*
    // 9. Generic Swap Method

    int first = 10;
    int second = 20;

    Swap(ref first, ref second);

    Console.WriteLine(first);
    Console.WriteLine(second);

    void Swap<T>(ref T first, ref T second)
    {
        T temp = first;
        first = second;
        second = temp;
    }

    // Key Point:
    // A generic method can swap values of different types.
*/



/*
    // 10. Find an Item in an Array

    int[] numbers = { 10, 20, 30, 40 };

    Console.WriteLine(FindItem(numbers, 30));
    Console.WriteLine(FindItem(numbers, 99));

    bool FindItem<T>(T[] items, T target)
    {
        foreach (T item in items)
        {
            if (EqualityComparer<T>.Default.Equals(item, target))
            {
                return true;
            }
        }

        return false;
    }

    // Key Point:
    // EqualityComparer<T>.Default compares values
    // without requiring a specific type.
*/



/*
    // 11. Get the First Item

    int[] numbers = { 10, 20, 30 };
    string[] names = { "Ali", "Mona", "Omar" };

    Console.WriteLine(GetFirst(numbers));
    Console.WriteLine(GetFirst(names));

    T GetFirst<T>(T[] items)
    {
        if (items.Length == 0)
        {
            throw new ArgumentException("Array cannot be empty.");
        }

        return items[0];
    }

    // Key Point:
    // A generic method can return a value of type T.
*/



// 12. Generic Method with a Default Value
/*
Console.WriteLine(default(int));
Console.WriteLine(GetDefault<bool>());
Console.WriteLine(GetDefault<string>() ?? "No value");

T GetDefault<T>()
{
    return default;
}*/

// Key Point:
// default(T) returns the default value for the chosen type.
// For example: 0 for int, false for bool, null for string.




// ============================================================
// PART 3 - GENERIC CLASSES
// ============================================================



// 13. A Generic Class
/*
Box<int> intBox = new Box<int>(100);
Box<string> stringBox = new Box<string>("Hello");

Console.WriteLine(intBox.Value);
Console.WriteLine(stringBox.Value);


class Box<T>
{
    public T Value;

    public Box(T value) => Value = value;

}*/

// Key Point:
// A generic class can store values of different types.




/*
    // 14. Generic Class with a Property

    Box<double> box = new Box<double>();

    box.Value = 25.5;

    Console.WriteLine(box.Value);


    class Box<T>
    {
        public T Value { get; set; }
    }

    // Key Point:
    // T can be used as the type of a property.
*/



/*
    // 15. Generic Class with a Method

    Container<int> container = new Container<int>();

    container.Add(10);
    container.Add(20);

    Console.WriteLine(container.GetValue());


    class Container<T>
    {
        private T _value;

        public void Add(T value)
        {
            _value = value;
        }

        public T GetValue()
        {
            return _value;
        }
    }

    // Key Point:
    // Generic classes can use T in fields,
    // parameters, properties, and return types.
*/



/*
    // 16. Generic Class with Two Type Parameters

    Pair<string, int> student = new Pair<string, int>("Mahmoud", 20);

    Console.WriteLine(student.First);
    Console.WriteLine(student.Second);


    class Pair<TFirst, TSecond>
    {
        public TFirst First { get; set; }
        public TSecond Second { get; set; }

        public Pair(TFirst first, TSecond second)
        {
            First = first;
            Second = second;
        }
    }

    // Key Point:
    // A generic class can define more than one type parameter.
*/



/*
    // 17. A Generic Class with a List

    Repository<int> repository = new Repository<int>();

    repository.Add(10);
    repository.Add(20);
    repository.Add(30);

    foreach (int item in repository.GetAll())
    {
        Console.WriteLine(item);
    }


    class Repository<T>
    {
        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public List<T> GetAll()
        {
            return _items;
        }
    }

    // Key Point:
    // A generic class can manage a collection of T values.
*/



// ============================================================
// PART 4 - GENERIC CONSTRAINTS
// ============================================================



// 18. What Is a Constraint?

// A constraint restricts which types can be used for T.

// Example:
// where T : IComparable<T>

// This allows the method to use CompareTo().
// The compiler knows that T supports this interface.

// Key Point:
// Constraints give the compiler guarantees about type T.





// 19. Using IComparable<T>

/* int first = 10;
 string second = ;

 Console.WriteLine(first.CompareTo(second));
 Console.WriteLine(second.CompareTo(first));
 Console.WriteLine(first.CompareTo(first));*/

// Key Point:
// CompareTo returns:
// Negative if this value is smaller.
// Zero if both values are equal.
// Positive if this value is greater.





// 20. Generic Method with IComparable<T>
/*
Console.WriteLine(CompareValues(10, 20));
Console.WriteLine(CompareValues("Ali", "Mona"));

int CompareValues<T>(T first, T second) where T : IComparable<T>
{
    return first.CompareTo(second);
}*/

// Key Point:
// IComparable<T> allows T to be compared using CompareTo().





// 22. Find the Minimum Value

/*Console.WriteLine(GetMin(10, 50));
Console.WriteLine(GetMin(9.5, 3.2));

T GetMin<T>(T first, T second)
    where T : IComparable<T>
{
    return first.CompareTo(second) < 0 ? first : second;
}*/

// Key Point:
// CompareTo() can be used to find the smaller value.





// 23. Comparing Custom Objects

/*Product p1 = new Product("Keyboard", 500);
Product p2 = new Product("Mouse", );

Product result = GetMoreExpensive(p1, p2);

Console.WriteLine(result.Name);
Console.WriteLine(result.Price);

T GetMoreExpensive<T>(T first, T second) where T : IComparable<T>
{
    return first.CompareTo(second) > 0 ? first : second;
}

class Product : IComparable<Product>
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public int CompareTo(Product other)
    {
        if (other == null)
        {
            return 1;
        }

        return Price.CompareTo(other.Price);
    }
}*/

// Key Point:
// A custom class can implement IComparable<T>
// to define how its objects are compared.




// ============================================================
// PART 5 - WHERE T : NEW()
// ============================================================



// 24. What Does where T : new() Mean?

// It requires T to have a public parameterless constructor.

// Valid examples:
// new Box<int>()
// new Box<Person>()

// Invalid example:
// A class with only a constructor that requires parameters.

// Key Point:
// new() lets generic code create an instance using new T().





// 25. Basic new() Constraint
/*
Person person = CreateObject<Person>();

person.Name = "Mahmoud";

Console.WriteLine(person.Name);

T CreateObject<T>() where T : new()
{
    return new T();
}


class Person
{
    public string Name { get; set; }
}*/

// Key Point:
// T must have a public parameterless constructor.





// 27. new() with a Class That Has a Constructor

/*Student student = Create<Student>();

student.Name = "Ali";

Console.WriteLine(student.Name);

T Create<T>()
    where T : new()
{
    return new T();
}


class Student
{
    public string Name { get; set; }

    public Student()
    {
        Name = "Unknown";
    }
}*/

// Key Point:
// The parameterless constructor runs when new T() is called.





// 28. Why a Parameterized Constructor Alone Is Not Enough

// This call would fail to compile:
// Create<Person>();

// Person has no public parameterless constructor.

/*T Create<T>() where T : new()
{
    return new T();
}


class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }
}*/

// Key Point:
// A constructor that requires arguments does not satisfy new().



// ============================================================
// PART 7 - IMPORTANT DIFFERENCES
// ============================================================


/*
    // 31. Generic Method vs Generic Class

    // Generic Method:
    // The type parameter belongs to a method.

    Print<int>(100);

    void Print<T>(T value)
    {
        Console.WriteLine(value);
    }


    // Generic Class:
    // The type parameter belongs to a class.

    Box<string> box = new Box<string>("Hello");

    Console.WriteLine(box.Value);


    class Box<T>
    {
        public T Value { get; set; }

        public Box(T value)
        {
            Value = value;
        }
    }

    // Key Point:
    // A method defines its own T.
    // A generic class defines T for its members.
*/



/*
    // 32. Generic Method vs Overloaded Methods

    Print(100);
    Print("Hello");

    void Print<T>(T value)
    {
        Console.WriteLine(value);
    }

    // Key Point:
    // Generics reduce the need to write
    // separate overloads for every data type.
*/



/*
    // 33. Explicit Type Argument vs Type Inference

    Print<int>(100);
    Print("Hello");

    void Print<T>(T value)
    {
        Console.WriteLine(value);
    }

    // Key Point:
    // Explicit: Print<int>(100)
    // Inference: Print(100)
*/



/*
    // 34. Constraint vs No Constraint

    Console.WriteLine(GetMax(10, 20));

    T GetMax<T>(T first, T second)
        where T : IComparable<T>
    {
        return first.CompareTo(second) > 0 ? first : second;
    }

    // Key Point:
    // A constraint allows operations that are guaranteed
    // by the required type or interface.
*/
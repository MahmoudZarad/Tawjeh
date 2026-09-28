/*
    ============================================================
        C# - CONSTRUCTORS & STATIC KEYWORD
    ============================================================

    TOPICS COVERED:

    CONSTRUCTORS
    - Basic Constructor
    - Parameterized Constructor
    - Multiple Constructors
    - Constructor Overloading
    - this Keyword
    - Constructor Chaining
    - Copy Constructor
    - Constructors with Inheritance
    - base Constructor
    - Constructor Execution Order
    - Access Modifiers with Constructors
    - Private Constructor
    - Object Initializer

    STATIC
    - Static Field
    - Static vs Instance Members
    - Static Method
    - Instance Method
    - Static vs Instance Access
    - this with Static
    - Static Property
    - Static Class
    - Static Constructor
    - Static Constructor Rules
    - Static with Inheritance
    - Static Counter
    - Static vs const
    - Reference vs Object
*/


// ============================================================
// PART 1 - CONSTRUCTORS
// ============================================================


// 1. Basic Constructor

/*
Person person = new Person();

Console.WriteLine(person.Name);


class Person
{
    public string Name;

    public Person()
    {
        Name = "Unknown";
    }
}

Key Point:
A constructor runs automatically when an object is created.
It is used to initialize the object.
*/


// ============================================================


// 2. Parameterized Constructor

/*Person person = new Person("Mahmoud", 20);

Console.WriteLine(person.Name);
Console.WriteLine(person.Age);


class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}*/



// ============================================================


// 3. Multiple Constructors

/*
Person p1 = new Person();
Person p2 = new Person("Mahmoud");
Person p3 = new Person("Mahmoud", 20);

Console.WriteLine(p1.Name);
Console.WriteLine(p2.Name);
Console.WriteLine(p3.Name);


class Person
{
    public string Name;
    public int Age;

    public Person()
    {
        Name = "Unknown";
        Age = 0;
    }

    public Person(string name)
    {
        Name = name;
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

Key Point:
A class can have multiple constructors
with different parameter lists.
*/


// ============================================================


// 4. Constructor Overloading

/*
Product p1 = new Product();
Product p2 = new Product("Laptop");
Product p3 = new Product("Laptop", 30000);

Console.WriteLine(p1.Name);
Console.WriteLine(p2.Name);
Console.WriteLine(p3.Price);


class Product
{
    public string Name;
    public double Price;

    public Product()
    {
    }

    public Product(string name)
    {
        Name = name;
    }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
}

Key Point:
Constructor Overloading means having multiple constructors
with different signatures.
*/


// ============================================================
// PART 2 - this KEYWORD
// ============================================================


// 5. this Keyword

/*
Person person = new Person("Mahmoud", 20);

Console.WriteLine(person.Name);
Console.WriteLine(person.Age);


class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}

Key Point:
this refers to the current object.
*/


// ============================================================
// PART 3 - CONSTRUCTOR CHAINING
// ============================================================


// 7. Constructor Chaining

/*
Person p1 = new Person();
Person p2 = new Person("Mahmoud");
Person p3 = new Person("Mahmoud", 20);

Console.WriteLine($"{p1.Name} - {p1.Age}");
Console.WriteLine($"{p2.Name} - {p2.Age}");
Console.WriteLine($"{p3.Name} - {p3.Age}");


class Person
{
    public string Name;
    public int Age;

    public Person() : this("Unknown", 0)
    {
    }

    public Person(string name) : this(name, 0)
    {
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

Key Point:
this(...) calls another constructor
in the same class.
*/


// ============================================================
// PART 4 - COPY CONSTRUCTOR
// ============================================================


// 9. Copy Constructor

/*
Person p1 = new Person("Mahmoud", 20);

Person p2 = new Person(p1);

Console.WriteLine(p1.Name);
Console.WriteLine(p2.Name);

Console.WriteLine(p1 == p2);


class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public Person(Person person)
    {
        Name = person.Name;
        Age = person.Age;
    }
}

Key Point:
A Copy Constructor creates a new object
using another object's data.
*/


// ============================================================
// PART 5 - CONSTRUCTORS WITH INHERITANCE
// ============================================================


// 11. Base and Derived Constructors

/*
Student student = new Student();


class Person
{
    public Person()
    {
        Console.WriteLine("Person Constructor");
    }
}

class Student : Person
{
    public Student()
    {
        Console.WriteLine("Student Constructor");
    }
}

Key Point:
The base constructor runs before
the derived constructor.
*/


// ============================================================


// 12. base Constructor

/*
Student student = new Student("Mahmoud", 3);

Console.WriteLine(student.Name);
Console.WriteLine(student.Level);


class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }
}

class Student : Person
{
    public int Level;

    public Student(string name, int level)
        : base(name)
    {
        Level = level;
    }
}

Key Point:
base(...) calls a constructor
from the base class.
*/


// ============================================================


// 13. Constructor Execution Order

/*
C obj = new C();


class A
{
    public A()
    {
        Console.WriteLine("A");
    }
}

class B : A
{
    public B()
    {
        Console.WriteLine("B");
    }
}

class C : B
{
    public C()
    {
        Console.WriteLine("C");
    }
}

Key Point:
Constructors execute from the base class
to the derived class.

Output:
A
B
C
*/


// ============================================================
// PART 6 - ACCESS MODIFIERS WITH CONSTRUCTORS
// ============================================================


// 14. Public Constructor

/*
Person person = new Person();


class Person
{
    public Person()
    {
        Console.WriteLine("Public Constructor");
    }
}

Key Point:
A public constructor can be called
from outside the class.
*/


// ============================================================


// 15. Private Constructor

/*
Person person = new Person();


class Person
{
    private Person()
    {
    }
}*/


/*
Key Point:
A private constructor cannot be called
from outside the class.
*/


// ============================================================


// 16. Private Constructor with Factory Method

/*
Person person = Person.Create();

Console.WriteLine(person.Name);


class Person
{
    public string Name = "Mahmoud";

    private Person()
    {
    }

    public static Person Create()
    {
        return new Person();
    }
}

Key Point:
A private constructor can control
how objects are created.
*/


// ============================================================
// PART 7 - OBJECT INITIALIZER
// ============================================================


// 17. Constructor vs Object Initializer

/*
Person p1 = new Person("Mahmoud", 20);

Person p2 = new Person
{
    Name = "Ahmed",
    Age = 21
};

Console.WriteLine(p1.Name);
Console.WriteLine(p2.Name);


class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

Key Point:
A constructor initializes during creation.
An object initializer sets members after creation.
*/


// ============================================================
// PART 8 - STATIC FIELDS
// ============================================================


// 18. Static Field

/*Person p1 = new Person();
Person p2 = new Person();

Person.Count++;
Person.Count++;

Console.WriteLine(Person.Count);


class Person
{
    public string Name;

    public static int Count;
}*/

/*
Key Point:
A static field belongs to the class
and has one shared value.
*/


// ============================================================


// 19. Static vs Instance

/*Person p1 = new Person();
Person p2 = new Person();

p1.Name = "Mahmoud";
p2.Name = "Ahmed";

Console.WriteLine(p1.Name);
Console.WriteLine(p2.Name);

Console.WriteLine(Person.Country);


class Person
{
    public string Name;

    public static string Country = "Egypt";
}*/

/*
Key Point:
Instance members belong to each object.
Static members are shared by the class.
*/


// ============================================================
// PART 9 - STATIC METHODS
// ============================================================


// 20. Static Method

/*int result = Calculator.Add(10, 20);

Console.WriteLine(result);


class Calculator
{
    public static int Add(int x, int y)
    {
        return x + y;
    }
}*/

/*
Key Point:
A static method can be called using
the class name without an object.
*/


// ============================================================


// 21. Instance Method

/*Person person = new Person();

person.SayHello();


class Person
{
    public void SayHello()
    {
        Console.WriteLine("Hello");
    }
}*/

/*
Key Point:
An instance method requires an object
to be called.
*/


// ============================================================
// PART 10 - STATIC VS INSTANCE ACCESS
// ============================================================


// 22. Static Method Cannot Access Instance Member

/*Person.PrintName();


class Person
{
    public string Name;

    public static void PrintName()
    {
        // Console.WriteLine(Name);
    }
}*/

/*
Key Point:
A static method has no specific object,
so it cannot directly access instance members.
*/


// ============================================================


// 23. Instance Method Can Access Static Member

/*Person person = new Person();

person.Name = "Mahmoud";

person.PrintData();


class Person
{
    public string Name;

    public static string Country = "Egypt";

    public void PrintData()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Country);
    }
}
*/

/*
Key Point:
An instance method can access both
instance and static members.
*/


// ============================================================


// 24. this Cannot Be Used in Static
/*
Person.Test();


class Person
{
    public string Name;

    public static void Test()
    {
        // Console.WriteLine(this.Name);
    }
}*/

/*
Key Point:
this refers to the current object.
Static members are not tied to a specific object.
*/


// ============================================================
// PART 11 - STATIC PROPERTY
// ============================================================


// 25. Static Property

/*Application.AppName = "Student System";

Console.WriteLine(Application.AppName);


class Application
{
    public static string AppName { get; set; }
}*/

/*
Key Point:
Properties can also be static
and shared by the class.
*/


// ============================================================
// PART 12 - STATIC CLASS
// ============================================================


// 26. Static Class

/*Console.WriteLine(Calculator.Add(10, 20));
Console.WriteLine(Calculator.Multiply(5, 4));


static class Calculator
{
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Multiply(int x, int y)
    {
        return x * y;
    }
}
*/
/*
Key Point:
A static class cannot be instantiated.
Its members are accessed through the class.
*/


// ============================================================


// 27. Static Class Cannot Create Objects

// Calculator calculator = new Calculator();


/*static class Calculator
{
    public static int Add(int x, int y)
    {
        return x + y;
    }
}*/

/*
Key Point:
A static class cannot have objects.
*/


// ============================================================
// PART 13 - STATIC CONSTRUCTOR
// ============================================================


// 28. Static Constructor

/*Person p1 = new Person();

Person p2 = new Person();


class Person
{
    static Person()
    {
        Console.WriteLine("Static Constructor");
    }

    public Person()
    {
        Console.WriteLine("Instance Constructor");
    }
}*/

/*
Key Point:
The static constructor runs once for the class.
The instance constructor runs once per object.
*/


// ============================================================


// 29. Static Constructor Execution

/*Console.WriteLine("Before");

Person p1 = new Person();

Console.WriteLine("Between");

Person p2 = new Person();

Console.WriteLine("After");


class Person
{
    static Person()
    {
        Console.WriteLine("Static Constructor");
    }

    public Person()
    {
        Console.WriteLine("Instance Constructor");
    }
}
*/
/*
Key Point:
The static constructor runs before the first
instance is created and only once.
*/


// ============================================================


// 30. Static Constructor Rules

/*
class Person
{
    static Person()
    {
        Console.WriteLine("Static Constructor");
    }
}

/*
Rules:
- No access modifier
- No parameters
- Same name as the class
- Runs automatically
- Runs only once
*/


// ============================================================
// PART 14 - STATIC WITH INHERITANCE
// ============================================================


// 31. Static Member in Base Class

/*Console.WriteLine(Student.Country);


class Person
{
    public static string Country = "Egypt";
}

class Student : Person
{
}*/

/*
Key Point:
A derived class can access
inherited static members.
*/


// ============================================================


// 32. Shared Static Member

/*Person.Count++;
Student.Count++;
Teacher.Count++;

Console.WriteLine(Person.Count);


class Person
{
    public static int Count;
}

class Student : Person
{
}

class Teacher : Person
{
}*/

/*
Key Point:
A static member is shared.
It is not duplicated for each object.
*/


// ============================================================
// PART 15 - CONSTRUCTOR + STATIC
// ============================================================


// 33. Static Counter with Constructor

/*Student s1 = new Student("Mahmoud");
Student s2 = new Student("Ahmed");
Student s3 = new Student("Omar");

Console.WriteLine(Student.Count);


class Student
{
    public string Name;

    public static int Count;

    public Student(string name)
    {
        Name = name;
        Count++;
    }
}*/

/*
Key Point:
The constructor runs for every object,
while the static counter is shared.
*/


// ============================================================


// 34. Static Constructor + Instance Constructor

/*Database db1 = new Database();

Database db2 = new Database();

Console.WriteLine(Database.ConnectionString);


class Database
{
    public static string ConnectionString;

    static Database()
    {
        ConnectionString = "Server=localhost";

        Console.WriteLine("Static Constructor");
    }

    public Database()
    {
        Console.WriteLine("Instance Constructor");
    }
}*/

/*
Key Point:
Static constructor -> once for the class.
Instance constructor -> once for each object.
*/


// ============================================================
// PART 16 - IMPORTANT DIFFERENCES
// ============================================================


// 35. static vs const

/*Person.Count++;

Console.WriteLine(Person.Count);
Console.WriteLine(Person.Max);


class Person
{
    public static int Count = 0;

    public const int Max = 100;
}*/

/*
Key Point:
static means class-level.
const means the value cannot change.
*/


// ============================================================


// 36. Reference vs Object

/*Person person;

Person person2 = new Person();


class Person
{
}*/

/*
Key Point:
Declaring a reference does not create an object.
new creates the object.
*/


// ============================================================
// END
// ============================================================
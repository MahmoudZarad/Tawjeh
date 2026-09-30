/*
    ============================================================
        C# - INHERITANCE & POLYMORPHISM
    ============================================================

    TOPICS COVERED:

    INHERITANCE
    - What is Inheritance?
    - Base Class / Parent Class
    - Derived Class / Child Class
    - Inheriting Fields and Methods
    - Access Modifiers with Inheritance
    - Multiple Levels of Inheritance
    - IS-A Relationship

    BASE KEYWORD
    - What is base?
    - base.Field
    - base.Method()
    - base Constructor
    - Passing Parameters to base Constructor
    - base vs this

    METHOD OVERRIDING
    - What is Method Overriding?
    - virtual Keyword
    - override Keyword
    - Why use virtual?
    - Overriding a Method
    - Calling the Base Version with base.Method()
    - virtual vs override

    POLYMORPHISM
    - What is Polymorphism?
    - Base Reference -> Derived Object
    - Runtime Polymorphism
    - Same Method Call -> Different Behavior
    - Polymorphism with Multiple Derived Classes
    - Polymorphism with Collections

    IMPORTANT DIFFERENCES
    - Inheritance vs Polymorphism
    - virtual vs override
    - this vs base
    - Base Reference vs Derived Reference
    - Method Overloading vs Method Overriding
*/


// ============================================================
// PART 1 - INHERITANCE
// ============================================================


/*
    // 1. Basic Inheritance

    Dog dog = new Dog();

    dog.Name = "Max";
    dog.Eat();
    dog.Bark();


    // Key Point:
    // Dog inherits accessible members from Animal.
    // Dog can also have its own members.

    class Animal
    {
        public string Name;

        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }
*/



/*
    // 2. Inherited Fields and Methods

    Student student = new Student();

    student.Name = "Mahmoud";
    student.Age = 20;

    student.Introduce();
    student.Study();


    // Key Point:
    // A derived class can use accessible fields and methods
    // inherited from its base class.

    class Person
    {
        public string Name;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("Student is studying.");
        }
    }
*/



/*
    // 3. Base Class and Derived Class

    Employee employee = new Employee();

    employee.Name = "Ali";
    employee.Salary = 15000;

    employee.Introduce();
    employee.Work();


    // Key Point:
    // Person is the Base Class.
    // Employee is the Derived Class.

    class Person
    {
        public string Name;

        public void Introduce()
        {
            Console.WriteLine($"Hello, I am {Name}.");
        }
    }

    class Employee : Person
    {
        public decimal Salary;

        public void Work()
        {
            Console.WriteLine("Employee is working.");
        }
    }
*/



/*
    // 4. Derived Class Can Add New Members

    Car car = new Car();

    car.Brand = "BMW";
    car.Start();
    car.Drive();


    // Key Point:
    // Inheritance does not limit the derived class.
    // The child can add its own fields and methods.

    class Vehicle
    {
        public string Brand;

        public void Start()
        {
            Console.WriteLine("Vehicle started.");
        }
    }

    class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }
*/



/*
    // 5. Access Modifiers with Inheritance

    Dog dog = new Dog();

    dog.Name = "Max";
    dog.ShowInfo();


    // Key Point:
    // public members are accessible from outside.
    // protected members are accessible inside derived classes.
    // private members are not directly accessible in derived classes.

    class Animal
    {
        public string Name;

        protected int Age;

        private string Secret = "Private Data";
    }

    class Dog : Animal
    {
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);

            // Console.WriteLine(Secret); // Error
        }
    }
*/



/*
    // 6. Multiple Levels of Inheritance

    Dog dog = new Dog();

    dog.Name = "Max";
    dog.Eat();
    dog.Walk();
    dog.Bark();


    // Key Point:
    // A class can inherit from another derived class.
    // This creates multiple levels of inheritance.

    class Animal
    {
        public string Name;

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    class Mammal : Animal
    {
        public void Walk()
        {
            Console.WriteLine("Walking...");
        }
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }
*/



/*
    // 7. IS-A Relationship

    Dog dog = new Dog();
    Car car = new Car();

    // Dog IS-A Animal
    // Car IS-A Vehicle


    // Key Point:
    // Inheritance represents an IS-A relationship.

    class Animal
    {
    }

    class Dog : Animal
    {
    }

    class Vehicle
    {
    }

    class Car : Vehicle
    {
    }
*/



// ============================================================
// PART 2 - BASE KEYWORD
// ============================================================


/*
    // 8. What is base?

    Dog dog = new Dog();

    dog.Show();


    // Key Point:
    // base refers to the current object's base class.

    class Animal
    {
        public string Name = "Animal";

        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class Dog : Animal
    {
        public void Show()
        {
            Console.WriteLine(base.Name);
            base.Eat();
        }
    }
*/



/*
    // 9. base.Field

    Student student = new Student();

    student.ShowNames();


    // Key Point:
    // base can access a field from the base class.

    class Person
    {
        public string Name = "Person Name";
    }

    class Student : Person
    {
        public string Name = "Student Name";

        public void ShowNames()
        {
            Console.WriteLine(Name);
            Console.WriteLine(base.Name);
        }
    }
*/



/*
    // 10. base.Method()

    Dog dog = new Dog();

    dog.Eat();


    // Key Point:
    // base.Method() calls the method from the base class.

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class Dog : Animal
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating.");

            base.Eat();
        }
    }
*/



/*
    // 11. base Constructor

    Student student = new Student();


    // Key Point:
    // The derived constructor can call the base constructor.

    class Person
    {
        public Person()
        {
            Console.WriteLine("Person constructor.");
        }
    }

    class Student : Person
    {
        public Student() : base()
        {
            Console.WriteLine("Student constructor.");
        }
    }
*/



/*
    // 12. Passing Parameters to base Constructor

    Student student = new Student("Mahmoud", 20);

    Console.WriteLine(student.Name);
    Console.WriteLine(student.Age);


    // Key Point:
    // base(...) passes arguments to the base constructor.

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

    class Student : Person
    {
        public Student(string name, int age)
            : base(name, age)
        {
        }
    }
*/



/*
    // 13. base vs this

    Student student = new Student("Mahmoud", 20);


    // Key Point:
    // this refers to the current class.
    // base refers to the parent class.

    class Person
    {
        public string Name;

        public Person(string name)
        {
            this.Name = name;
        }
    }

    class Student : Person
    {
        public int Age;

        public Student(string name, int age)
            : base(name)
        {
            this.Age = age;
        }
    }
*/



// ============================================================
// PART 3 - VIRTUAL AND OVERRIDE
// ============================================================


/*
    // 14. Why Do We Need virtual?

    Animal animal = new Animal();

    animal.Speak();


    // Key Point:
    // virtual allows a derived class to provide
    // its own implementation of a method.

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }
*/



/*
    // 15. Basic override

    Dog dog = new Dog();

    dog.Speak();


    // Key Point:
    // override replaces a virtual method in the derived class.

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }
*/



/*
    // 16. virtual + override

    Dog dog = new Dog();

    dog.Speak();
    dog.Eat();


    // Key Point:
    // The derived class can override only methods
    // that are virtual, abstract, or already overridden.

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal sound.");
        }

        public void Eat()
        {
            Console.WriteLine("Animal eating.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barking.");
        }
    }
*/



/*
    // 17. Calling the Base Version with base

    Dog dog = new Dog();

    dog.Speak();


    // Key Point:
    // base.Method() allows the override to call
    // the original base implementation.

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            base.Speak();

            Console.WriteLine("Dog barks.");
        }
    }
*/



/*
    // 18. Override Can Change the Behavior

    Animal animal = new Animal();
    Dog dog = new Dog();
    Cat cat = new Cat();

    animal.Speak();
    dog.Speak();
    cat.Speak();


    // Key Point:
    // Each derived class can provide its own behavior
    // for the same virtual method.

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows.");
        }
    }
*/



/*
    // 19. A Non-Virtual Method Cannot Be Overridden

    Dog dog = new Dog();

    dog.Eat();


    // Key Point:
    // A normal method cannot be overridden.
    // It must be virtual in the base class.

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal eating.");
        }
    }

    class Dog : Animal
    {
        // public override void Eat() // Error
        // {
        // }
    }
*/



// ============================================================
// PART 4 - POLYMORPHISM
// ============================================================


/*
    // 20. What is Polymorphism?

    Animal animal = new Dog();

    animal.Speak();


    // Key Point:
    // One base type can refer to an object of a derived type.
    // The overridden method is selected at runtime.

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }
*/



/*
    // 21. Base Reference -> Derived Object

    Animal animal = new Dog();

    animal.Speak();


    // Key Point:
    // The reference type is Animal,
    // but the actual object is Dog.

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }
*/



/*
    // 22. Runtime Polymorphism

    Animal animal;

    animal = new Dog();
    animal.Speak();

    animal = new Cat();
    animal.Speak();


    // Key Point:
    // The same reference can point to different objects.
    // The behavior is decided at runtime.

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows.");
        }
    }
*/



/*
    // 23. Same Method Call -> Different Behavior

    Animal dog = new Dog();
    Animal cat = new Cat();
    Animal cow = new Cow();

    dog.Speak();
    cat.Speak();
    cow.Speak();


    // Key Point:
    // The method call is the same,
    // but each object provides different behavior.

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
    }

    class Cow : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Moo");
        }
    }
*/



/*
    // 24. Polymorphism with a Method Parameter

    Dog dog = new Dog();
    Cat cat = new Cat();

    MakeAnimalSpeak(dog);
    MakeAnimalSpeak(cat);


    void MakeAnimalSpeak(Animal animal)
    {
        animal.Speak();
    }


    // Key Point:
    // A method can accept the base type
    // and work with any derived type.

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows.");
        }
    }
*/



/*
    // 25. Polymorphism with a Collection

    List<Animal> animals = new List<Animal>
    {
        new Dog(),
        new Cat(),
        new Cow()
    };

    foreach (Animal animal in animals)
    {
        animal.Speak();
    }


    // Key Point:
    // A collection of the base type can contain
    // objects from different derived classes.

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    class Cow : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cow moos.");
        }
    }
*/



/*
    // 26. Polymorphism in a Real Example

    Employee employee1 = new Developer();
    Employee employee2 = new Designer();

    employee1.Work();
    employee2.Work();


    // Key Point:
    // Polymorphism allows different types
    // to be treated through one common type.

    class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee is working.");
        }
    }

    class Developer : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Developer is writing code.");
        }
    }

    class Designer : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Designer is creating designs.");
        }
    }
*/



// ============================================================
// PART 5 - INHERITANCE + BASE + OVERRIDE TOGETHER
// ============================================================


/*
    // 27. Constructor + Inheritance + base

    Student student = new Student("Mahmoud", 20);

    student.Introduce();


    // Key Point:
    // The derived constructor can pass values
    // to the base constructor using base(...).

    class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Student : Person
    {
        public Student(string name, int age)
            : base(name, age)
        {
        }
    }
*/



/*
    // 28. Override + base.Method()

    Dog dog = new Dog();

    dog.Speak();


    // Key Point:
    // override changes the behavior,
    // while base.Method() can still call the parent behavior.

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            base.Speak();

            Console.WriteLine("Dog barks.");
        }
    }
*/



/*
    // 29. Full Example

    Animal animal1 = new Dog("Max");
    Animal animal2 = new Cat("Luna");

    animal1.ShowInfo();
    animal1.Speak();

    Console.WriteLine();

    animal2.ShowInfo();
    animal2.Speak();


    // Key Point:
    // Inheritance provides the relationship.
    // base accesses the parent.
    // override changes inherited behavior.
    // Polymorphism lets one base type handle different objects.

    class Animal
    {
        public string Name;

        public Animal(string name)
        {
            Name = name;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
        }

        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public Dog(string name)
            : base(name)
        {
        }

        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Dog barks.");
        }
    }

    class Cat : Animal
    {
        public Cat(string name)
            : base(name)
        {
        }

        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Cat meows.");
        }
    }
*/



// ============================================================
// PART 6 - IMPORTANT DIFFERENCES
// ============================================================


/*
    // 30. Inheritance vs Polymorphism

    // Inheritance:
    // Defines a relationship between classes.

    // Polymorphism:
    // Allows different derived objects
    // to be treated as the same base type.

    class Animal
    {
    }

    class Dog : Animal
    {
    }
*/



/*
    // 31. virtual vs override

    // Base class:
    // virtual = allows a method to be overridden.

    // Derived class:
    // override = provides a new implementation.

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }
*/



/*
    // 32. this vs base

    // this -> current class
    // base -> parent class

    class Person
    {
        public string Name;

        public Person(string name)
        {
            this.Name = name;
        }
    }

    class Student : Person
    {
        public int Age;

        public Student(string name, int age)
            : base(name)
        {
            this.Age = age;
        }
    }
*/



/*
    // 33. Base Reference vs Derived Reference

    Dog dog = new Dog();

    Animal animal = dog;


    // Key Point:
    // A derived object can be stored in a base reference.
    // This is one of the foundations of polymorphism.

    class Animal
    {
    }

    class Dog : Animal
    {
    }
*/



/*
    // 34. Method Overloading vs Method Overriding

    // OVERLOADING:
    // Same method name + different parameters.
    // Happens inside the same class or inheritance hierarchy.
    // Compile-time polymorphism.

    // OVERRIDING:
    // Same method signature in base and derived classes.
    // Requires virtual/override.
    // Runtime polymorphism.

    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }


    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }
*/



/*
    // 35. What Actually Happens with Polymorphism?

    Animal animal = new Dog();

    animal.Speak();


    // Step 1:
    // Reference type = Animal

    // Step 2:
    // Actual object = Dog

    // Step 3:
    // Speak() is virtual

    // Step 4:
    // C# checks the actual object at runtime

    // Step 5:
    // Dog's override is executed


    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }
*/



/*
    // 36. Final Combined Example

    List<Animal> animals = new List<Animal>
    {
        new Dog("Max"),
        new Cat("Luna"),
        new Bird("Rio")
    };

    foreach (Animal animal in animals)
    {
        animal.ShowInfo();
        animal.Speak();
        Console.WriteLine();
    }


    // Key Point:
    // This example combines:
    // Inheritance
    // base Constructor
    // virtual
    // override
    // base.Method()
    // Polymorphism

    class Animal
    {
        public string Name;

        public Animal(string name)
        {
            Name = name;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
        }

        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public Dog(string name)
            : base(name)
        {
        }

        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    class Cat : Animal
    {
        public Cat(string name)
            : base(name)
        {
        }

        public override void Speak()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    class Bird : Animal
    {
        public Bird(string name)
            : base(name)
        {
        }

        public override void Speak()
        {
            Console.WriteLine("Bird sings.");
        }
    }
*/
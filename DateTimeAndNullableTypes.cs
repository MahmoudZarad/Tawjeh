

// ============================================================================
//                   DATETIME AND NULLABLE TYPES
// ============================================================================
//
//                    C# Console Application
//
// ============================================================================















// ============================================================================
// PART 1 - DATETIME
// ============================================================================
//
// DateTime is a data type used to store:
//
//      Date
//        +
//      Time
//
// ============================================================================









// ============================================================================
// 1. DATETIME.NOW
// ============================================================================
//
// Gets the current date and time.
//
// ============================================================================


/*
DateTime now = DateTime.UtcNow;


Console.WriteLine(
    now
);*/


// UtcNow
// Now








// ============================================================================
// 2. DATETIME.TODAY
// ============================================================================
//
// Gets today's date.
//
// The time will be 00:00:00.
//
// ============================================================================


/*
DateTime today = DateTime.Today;


Console.WriteLine(
    today
);
*/










// ============================================================================
// 3. NOW VS TODAY
// ============================================================================

/*

Console.WriteLine(
    "Now: " + DateTime.Now
);


Console.WriteLine(
    "Today: " + DateTime.Today
);
*/










// ============================================================================
// 4. CREATE A SPECIFIC DATE
// ============================================================================
//
// Order:
//
//      Year
//      Month
//      Day
//
// ============================================================================



/*DateTime birthday =
    new DateTime(
        2015,
        5,
        23
    );


Console.WriteLine(
    birthday
);*/











// ============================================================================
// 5. CREATE A SPECIFIC DATE AND TIME
// ============================================================================
//
// Order:
//
//      Year
//      Month
//      Day
//      Hour
//      Minute
//      Second
//
// ============================================================================


/*
DateTime meeting =
    new DateTime(
        2026,
        9,
        10,
        18,
        30,
        0
    );


Console.WriteLine(
    meeting
);*/











// ============================================================================
// 6. GETTING DATE PARTS
// ============================================================================


/*
DateTime now = DateTime.Now;


Console.WriteLine(
    "Year: " + now.Year
);


Console.WriteLine(
    "Month: " + now.Month
);


Console.WriteLine(
    "Day: " + now.Day
);


*/








// ============================================================================
// 7. GETTING TIME PARTS
// ============================================================================

/*

DateTime now =
    DateTime.Now;


Console.WriteLine(
    "Hour: " + now.Hour
);


Console.WriteLine(
    "Minute: " + now.Minute
);


Console.WriteLine(
    "Second: " + now.Second
);

*/









// ============================================================================
// 8. DAY OF WEEK
// ============================================================================


/*
DateTime today =
    DateTime.Today;


Console.WriteLine(
    today.DayOfWeek
);
*/










// ============================================================================
// 9. ADD DAYS
// ============================================================================

/*

DateTime today =
    DateTime.Today;


DateTime tomorrow = today.AddDays(1);


Console.WriteLine(
    tomorrow
);
*/










// ============================================================================
// 10. ADD MULTIPLE DAYS
// ============================================================================

/*

DateTime today =
    DateTime.Today;


DateTime nextWeek =
    today.AddDays(
        7
    );


Console.WriteLine(
    nextWeek
);

*/









// ============================================================================
// 11. ADD MONTHS
// ============================================================================

/*

DateTime today =
    DateTime.Today;


DateTime futureDate =
    today.AddMonths(
        2
    );


Console.WriteLine(
    futureDate
);*/











// ============================================================================
// 12. ADD YEARS
// ============================================================================

/*

DateTime today =
    DateTime.Today;


DateTime nextYear =
    today.AddYears(
        1
    );


Console.WriteLine(
    nextYear
);

*/









// ============================================================================
// 13. ADD HOURS
// ============================================================================

/*

DateTime now =
    DateTime.Now;


DateTime later =
    now.AddHours(
        3
    );


Console.WriteLine(
    later
);

*/









// ============================================================================
// 14. ADD MINUTES
// ============================================================================

/*

DateTime now =
    DateTime.Now;


DateTime later =
    now.AddMinutes(
        30
    );


Console.WriteLine(
    later
);

*/









// ============================================================================
// 15. SUBTRACTING DATES
// ============================================================================
//
// Date - Date = TimeSpan
//
// ============================================================================


/*
DateTime date1 =
    new DateTime(
        2026,
        9,
        8
    );


DateTime date2 =
    new DateTime(
        2026,
        9,
        10
    );


TimeSpan difference =
    date1 - date2;


//if (date1 < date2)
//{
//    Console.WriteLine(
//        "Date 1 is earlier."
//    );
//}
//else
//{
//    Console.WriteLine("Date 2 is earlier.");
//}

//Console.WriteLine(
//    difference.TotalHours
//);


//Console.WriteLine(
//    difference.Hours
//);





double number = DateTime.Compare(new DateTime(2026, 9, 20), new DateTime(2026, 9, 15));

Console.WriteLine(number);



*/


// ============================================================================
// PART 2 - TIMESPAN
// ============================================================================
//
// TimeSpan represents:
//
//      A duration
//
// OR
//
//      The difference between two dates
//
// ============================================================================









// ============================================================================
// 16. CREATE A TIMESPAN
// ============================================================================



/*TimeSpan time =
    new TimeSpan(
        2,
        30,
        0
    );


Console.WriteLine(
    time
);



*/







// ============================================================================
// 17. TIMESPAN PROPERTIES
// ============================================================================


/*
TimeSpan time =
    new TimeSpan(
        2,
        30,
        45
    );


Console.WriteLine(
    "Hours: " + time.Hours
);


Console.WriteLine(
    "Minutes: " + time.Minutes
);


Console.WriteLine(
    "Seconds: " + time.Seconds
);
*/










// ============================================================================
// 18. TIMESPAN TOTAL PROPERTIES
// ============================================================================

/*

TimeSpan time =
    new TimeSpan(
        2,
        30,
        0
    );


Console.WriteLine(
    "Total Hours: "
    + time.TotalHours
);


Console.WriteLine(
    "Total Minutes: "
    + time.TotalMinutes
);
*/










// ============================================================================
// PART 3 - DATETIME FORMATTING
// ============================================================================









// ============================================================================
// 19. DEFAULT DATETIME FORMAT
// ============================================================================

/*

DateTime now =
    DateTime.Now;


Console.WriteLine(
    now
);

*/









// ============================================================================
// 20. YEAR - MONTH - DAY
// ============================================================================

/*

DateTime now =
    DateTime.Now;


Console.WriteLine(
    now.ToString(
        "yyyy-MM-dd"
    )
);

*/









// ============================================================================
// 21. DAY / MONTH / YEAR
// ============================================================================

/*

DateTime now =
    DateTime.Now;


Console.WriteLine(
    now.ToString(
        "dd/MM/yyyy"
    )
);

*/









// ============================================================================
// 22. 24-HOUR TIME
// ============================================================================

/*

DateTime now =
    DateTime.Now;


Console.WriteLine(
    now.ToString(
        "HH:mm"
    )
);

*/









// ============================================================================
// 23. 12-HOUR TIME
// ============================================================================

/*

DateTime now =
    DateTime.Now;


Console.WriteLine(
    now.ToString(
        "hh:mm tt"
    )
);

*/









// ============================================================================
// 24. DAY NAME
// ============================================================================

/*

DateTime now =
    DateTime.Now;


Console.WriteLine(
    now.ToString(
        "dddd"
    )
);

*/









// ============================================================================
// 25. CUSTOM FORMAT
// ============================================================================

/*

DateTime now =
    DateTime.Now;


Console.WriteLine(
    now.ToString(
        "dddd, dd MMMM yyyy - hh:mm tt"
    )
);

*/









// ============================================================================
// PART 4 - PARSING DATETIME
// ============================================================================









// ============================================================================
// 26. DATETIME.PARSE
// ============================================================================
//
// Converts a string into DateTime.
//
// ============================================================================

/*

Console.Write(
    "Enter a date: "
);


string input =
    Console.ReadLine();


DateTime date =
    DateTime.Parse(
        input
    );


Console.WriteLine(
    "Date: " + date
);

*/









// ============================================================================
// 27. DATETIME.TRYParse
// ============================================================================
//
// Safely tries to convert a string into DateTime.
//
// ============================================================================

/*

Console.Write(
    "Enter a date: "
);


string input =
    Console.ReadLine();


bool isValid =
    DateTime.TryParse(
        input,
        out DateTime date
    );


if (isValid)
{
    Console.WriteLine(
        "Valid Date!"
    );


    Console.WriteLine(
        date
    );
}
else
{
    Console.WriteLine(
        "Invalid Date!"
    );
}

*/









// ============================================================================
// 28. PARSE VS TRYPARSE
// ============================================================================
//
// DateTime.Parse
//
//      Invalid Input
//          ↓
//      Exception
//
//
// DateTime.TryParse
//
//      Invalid Input
//          ↓
//      Returns false
//
// ============================================================================

/*

string input =
    "Hello";


// This may throw an exception:

// DateTime date =
//     DateTime.Parse(
//         input
//     );


// This does NOT throw an exception:

bool isValid =
    DateTime.TryParse(
        input,
        out DateTime date
    );


Console.WriteLine(
    isValid
);

*/









// ============================================================================
// PART 5 - NULLABLE TYPES
// ============================================================================
//
// A nullable type can contain:
//
//      A Value
//
//        OR
//
//      null
//
// ============================================================================









// ============================================================================
// 29. NORMAL VALUE TYPE
// ============================================================================

/*

int age =
    20;


Console.WriteLine(
    age
);


// int age = null;
//
// ERROR!
//

*/









// ============================================================================
// 30. NULLABLE INT
// ============================================================================

/*

int? age =
    null;


Console.WriteLine(
    age
);

*/









// ============================================================================
// 31. NULLABLE TYPES
// ============================================================================

/*

int? age =
    null;

Nullable<int> age2 =
    null;

Nullable<double> price2 =
    null;

double? price =
    null;


bool? isActive =
    null;


DateTime? birthday =
    null;


Console.WriteLine(
    "Nullable variables created."
);




*/






// ============================================================================
// 32. ASSIGNING A VALUE
// ============================================================================

/*

int? age =
    null;


Console.WriteLine(
    age
);


age =
    20;


Console.WriteLine(
    age
);

*/









// ============================================================================
// 33. HASVALUE
// ============================================================================


/*
int? age =
    null;


if (
    age.HasValue)
{
    Console.WriteLine(
        "Age has a value."
    );
}
else
{
    Console.WriteLine(""
}

*/









// ============================================================================
// 34. HASVALUE WITH NULL
// ============================================================================

/*

int? age =
    null;


if (
    !age.HasValue
)
{
    Console.WriteLine(
        "Age has no value."
    );
}

*/









// ============================================================================
// 35. .VALUE
// ============================================================================
//
// Use .Value only when you know the value is NOT null.
//
// ============================================================================

/*

int? age =
    null;


Console.WriteLine(
    age.Value
);
*/










// ============================================================================
// 36. SAFE USE OF .VALUE
// ============================================================================


/*
int? age =
    null;


if (age.HasValue)
{
    Console.WriteLine(
        age.Value
    );
}
else
{
    Console.WriteLine("Age is null.");
}


*/








// ============================================================================
// 37. NULL-COALESCING OPERATOR ??
// ============================================================================
//
// If the value is null,
// use the value on the right.
//
// ============================================================================



//int? age =
//    5;


//int result = age ?? 6;


//Console.WriteLine(
//    result
//);











// ============================================================================
// 38. ?? WITH A VALUE
// ============================================================================


/*
int? age =
    20;


int result =
    age ?? 0;


Console.WriteLine(
    result
);
*/










// ============================================================================
// 39. NULLABLE DATETIME
// ============================================================================


/*
DateTime? graduationDate =
    null;


Console.WriteLine(
    graduationDate
);
*/










// ============================================================================
// 40. CHECK NULLABLE DATETIME
// ============================================================================

/*

DateTime? graduationDate =
    null;


if (
    graduationDate.HasValue
)
{
    Console.WriteLine(
        graduationDate.Value
    );
}
else
{
    Console.WriteLine(
        "The student has not graduated yet."
    );
}

*/









// ============================================================================
// 41. NULLABLE DATETIME WITH ??
// ============================================================================

/*

DateTime? graduationDate =
    null;


DateTime result =
    graduationDate
    ??
    DateTime.Today;


Console.WriteLine(
    result
);

*/









// ============================================================================
// 42. REAL EXAMPLE - STUDENT
// ============================================================================

/*

string name =
    "Mahmoud";


int? age =
    null;


DateTime? graduationDate =
    null;


Console.WriteLine(
    "Name: " + name
);


if (
    age.HasValue
)
{
    Console.WriteLine(
        "Age: " + age.Value
    );
}
else
{
    Console.WriteLine(
        "Age is not available."
    );
}


if (
    graduationDate.HasValue
)
{
    Console.WriteLine(
        "Graduation Date: "
        + graduationDate.Value
    );
}
else
{
    Console.WriteLine(
        "Not graduated yet."
    );
}

*/









// ============================================================================
// 43. DATE DIFFERENCE - DAYS UNTIL EXAM
// ============================================================================

/*

DateTime today =
    DateTime.Today;


DateTime examDate =
    new DateTime(
        2026,
        12,
        1
    );


TimeSpan difference =
    examDate - today;


Console.WriteLine(
    "Days remaining: "
    + difference.Days
);

*/









// ============================================================================
// 44. SIMPLE AGE CALCULATION
// ============================================================================

/*

DateTime birthDate =
    new DateTime(
        2006,
        5,
        23
    );


DateTime today =
    DateTime.Today;


int age =
    today.Year
    -
    birthDate.Year;


if (
    birthDate.Date
    >
    today.AddYears(
        -age
    )
)
{
    age--;
}


Console.WriteLine(
    "Age: " + age
);

*/









// ============================================================================
// 45. FINAL PRACTICE
// ============================================================================
//
// Exercise 1:
//
// Create a DateTime variable
// for your birthday.
//
// Print:
//
//      Year
//      Month
//      Day
//
// ---------------------------------------------------------------------------
//
// Exercise 2:
//
// Create two dates.
//
// Find the difference
// between them.
//
// ---------------------------------------------------------------------------
//
// Exercise 3:
//
// Ask the user to enter a date.
//
// Use DateTime.TryParse.
//
// ---------------------------------------------------------------------------
//
// Exercise 4:
//
// Create:
//
//      int? age
//
// Check if it has a value.
//
// ---------------------------------------------------------------------------
//
// Exercise 5:
//
// Create:
//
//      DateTime? graduationDate
//
// If it has a value:
//
//      Print the date.
//
// Otherwise:
//
//      Print:
//      "Not graduated yet."
//
// ---------------------------------------------------------------------------
//
// Exercise 6:
//
// Create a program that:
//
//      Asks the user for
//      their birth date.
//
//      Validates it using
//      DateTime.TryParse.
//
//      Calculates their age.
//
// ============================================================================
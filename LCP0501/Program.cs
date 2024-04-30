// MIS 3013 001
// May 1, 2024
// Alexandra Camarena
// 113568154
Console.WriteLine("Exam 3 Practice");

string menuStr = @"""
********************************************
1. Add a new student
2. Show all students' information
3. Search a student by ID
4. Show the student with smallest age
5. Show the average weight of all students
********************************************
    """;

while (true) 
{
    Console.WriteLine(menuStr);

    Console.Write($"Enter an option: ");
    string userChoiceStr = Console.ReadLine();

    if (userChoiceStr == "1")
    {
        // add a new student
        Console.Write($"Input student ID: ");
        string idStr = Console.ReadLine();

        Console.Write($"Input student name: ");
        string nameStr = Console.ReadLine();

        Console.Write($"Input student age: ");
        string ageStr = Console.ReadLine();
        int ageInt = Convert.ToInt32( ageStr );

        Console.Write($"Input student weight: ");
        string weightStr = Console.ReadLine();
        double weightDbl = Convert.ToDouble( weightStr );
    }
    else if (userChoiceStr == "2")
    {
        // show all students
    }
    else if (userChoiceStr == "3")
    {
        // search a student by ID
    }
    else if (userChoiceStr == "4")
    {
        // show student with smallest age
    }
    else if (userChoiceStr == "5")
    {
        // show average weight
    }
    else 
    {
        Console.WriteLine("Thnak you and goodbye!");
        break;
    }
}
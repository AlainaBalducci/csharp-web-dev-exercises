//Exercises: Control Flow & Collections

//TODO: Write your code for Dictionary Practice below:

Console.WriteLine("Hello, Dictionary!");
Dictionary<int, string> students = new Dictionary<int, string>();
string newStudent;
Console.WriteLine("Enter your students names and ID numbers (or ENTER to finish): ");
do
{
    Console.WriteLine("Student name: ");
    newStudent = Console.ReadLine();
    if (newStudent != "")
    {
        Console.WriteLine("ID: ");
        int newId = int.Parse(Console.ReadLine());
        students.Add(newId, newStudent);

    }
} while (!Equals(newStudent, ""));

foreach(KeyValuePair<int, string> student in students)
{
    Console.WriteLine($"{student.Key}, {student.Value }");
}

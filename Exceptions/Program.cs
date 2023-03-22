// --------- Divide By Zero! ----------


using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

static double Divide(double x, double y)
{
    if (y == 0)
    {
        throw new ArgumentOutOfRangeException("y", "You can not divide by zero!");
    }
    else
    {
        return x / y;
    }

    //try 
    //{
    //    return x / y;
    //}
    //catch (ArgumentOutOfRangeException e) 
    //{
    //    throw new ArgumentOutOfRangeException("y", "You can not divide by zero!");
    //}

    // Write your code here!
}
//Console.WriteLine(Divide(5, 0));
//Console.WriteLine(Divide(5, 5));

// Test out your Divide() function here!
//Console.WriteLine(Divide(5, 5));

// --------- Test Student Labs ----------


static int CheckFileExtension(string fileName)
{
    //int grades = 0;

    //if (fileName.EndsWith(".cs"))
    //{
    //    return grades += 1;
    //}
    //else if (!fileName.EndsWith(".cs"))
    //{
    //    return grades += 0;
    //}
    //else if (fileName == "" || fileName == null)
    //{
    //    throw new ArgumentNullException("There needs to be a file name and it has to end with .cs");
    //}
    //else
    //{
    //    return 0;
    //}

    if (fileName == null || fileName == "")
    {
        throw new ArgumentNullException("fileName", "Student did not submit any work!");
    }
    else
    {
        if (fileName.EndsWith(".cs"))
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }


}



// Test out your CheckFileExtension() function here!

Dictionary<string, string> students = new Dictionary<string, string>();
students.Add("Carl", "Program.cs");
students.Add("Brad", "");
students.Add("Elizabeth", "MyCode.cs");

Console.WriteLine(CheckFileExtension(students["Carl"]));
Console.WriteLine(CheckFileExtension(students["Brad"]));



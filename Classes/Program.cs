// TODO: Instantiate your objects and test your exercise solutions with print statements here.
using Classes;
using System.Runtime.Serialization.Formatters;




    Student newStudent = new Student("Alaina", 1, 1, 4.0);
    Student newStudent2 = new Student("Mary");
    Student newStudent3 = new Student("Joe");

    Console.WriteLine(newStudent2.StudentId);
    Console.WriteLine(newStudent3.StudentId);
    Console.WriteLine(newStudent.StudentId);

    newStudent.Name = "ALAINA";
    Console.WriteLine($"Name: {newStudent.Name}\nID:{newStudent.StudentId}\nCredits:{newStudent.NumberOfCredits}\nGPA:{newStudent.Gpa}");
    

    

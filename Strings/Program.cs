//Exercises: Control Flow & Collections

//TODO: Write your code for String Practice below:

using System.Linq.Expressions;

Console.WriteLine("Hello, Strings!");
string sentence = "I would not, could not, in a box. I would not, could not with a fox.\r\nI will not eat them in a house. I will not eat them with a mouse.";
string [] newArray = sentence.Split(' ');
Console.WriteLine(string.Join(",", newArray));
string[] seperate = sentence.Split(".");
Console.WriteLine(string.Join(",", seperate));
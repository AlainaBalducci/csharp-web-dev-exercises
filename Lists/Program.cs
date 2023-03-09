//Exercises: Control Flow & Collections

//TODO: Write your code for List Practice below:

using System.Diagnostics.Tracing;

Console.WriteLine("Hello, Lists!");

static int sumEven(List<int> list)
{
    int total = 0;
    foreach (int i in list)
    {
        if (i % 2 == 0)
        {
            total += i;
        }
    }
    return total;
}

List<int> newList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine(sumEven(newList));


static void fiveLetters(List<string> words)
{
    foreach (string word in words)
    {
        if (word.Length == 5)
        {
            Console.WriteLine(word);
        }
    }
}

Console.WriteLine("Enter a word length: ");
string input = Console.ReadLine();
int numChars = int.Parse(input);

static void xLetters(List<string> words, int length)
{
    foreach (string word in words)
    {
        if (word.Length == length)
        {
            Console.WriteLine(word);
        }
    }
}
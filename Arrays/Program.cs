//Exercises: Control Flow & Collections

//TODO: Write your code for Array Practice below:

Console.WriteLine("Hello, Arrays!");

int[] newArray = {1,1,2,3,5,8};

foreach(int num in newArray)
{
    if (num % 2 == 1)
    {
        Console.WriteLine(num);
    }
}
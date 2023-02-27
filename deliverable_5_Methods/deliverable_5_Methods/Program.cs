using System;

namespace deliverable_5_Methods;
class Program
{
 
    static int [] random_array(int array_length)
    {
        Random random = new Random();
        int[] MyArray = new int[array_length];
        for (int i = 0; i < array_length; i++)
        {
            MyArray[i] = random.Next(10, 150);

        }
        return MyArray;
        
    }

    static int sum(int[] array)
    {
        int sum = 0;
        foreach( int item in array)
        {
            sum = sum + item;
        }
        return sum;
    }
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter an integer between 5 and 15:");
            int input = int.Parse(Console.ReadLine());
            if (input >= 5 && input <= 15)
            {
                int[] sampleArray = random_array(input);

                Console.WriteLine("The elements in the random array are: ");

                foreach (int element in sampleArray)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine("\n");
                Console.WriteLine("The sum is: " + sum(sampleArray));
            }
            else
            {
                Console.WriteLine("The input can only be an integer between 5 and 15.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter an integer between 5 and 15.");
        }
    }
}
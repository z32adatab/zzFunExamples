using System;

// Define a class to hold the main method
class Program
{
  // Define a method to find the nth Fibonacci number
  static int Fibonacci(int n)
  {
    // Base cases: 0 and 1
    if (n == 0)
    {
      return 0;
    }
    else if (n == 1)
    {
      return 1;
    }
    // Recursive case: use the formula F(n) = F(n-1) + F(n-2)
    else
    {
      return Fibonacci(n-1) + Fibonacci(n-2);
    }
  }

  // Define the main method
  static void Main(string[] args)
  {
    // Ask the user for a positive integer
    Console.Write("Enter a positive integer: ");
    int n = int.Parse(Console.ReadLine());

    // Print the Fibonacci sequence up to the nth term
    Console.WriteLine("The Fibonacci sequence up to the " + n + "th term is:");
    for (int i = 0; i < n; i++)
    {
      Console.Write(Fibonacci(i) + " ");
    }
  }
}

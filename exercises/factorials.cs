using System;

//3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
//For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

namespace factorials
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Please enter a number: ");
      var input = Convert.ToInt32(Console.ReadLine());

      //while (input >= 1)
      //{
      //    var test = input - 1;

      //    Console.WriteLine(test);
      //}

      for (var i = 1; i < input; i++)
      {
        var numbers = i;
        Console.WriteLine(numbers);
      }

    }
  }
}

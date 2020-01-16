using System;

//2- Write a program which takes two numbers from the console and displays the maximum of the two.

namespace DisplayMaximum
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Please enter two numbers to reveal their maximum values");
      var numOne = Convert.ToInt32(Console.ReadLine());
      var numTwo = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("{0}, {1}", byte.MaxValue, byte.MaxValue);

    }
  }
}

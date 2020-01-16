using System;

//1- Write a program and ask the user to enter a number. The number should be between 1 to 10.
//If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
//(This logic is used a lot in applications where values entered into input boxes need to be validated.)

namespace challenge
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hello, please enter a valid number between 1 and 10");

      //must convert to type int because console.readline only accepts strings
      int number = Convert.ToInt32(Console.ReadLine());

      if (number >= 1 && number <= 10)
      {
        Console.WriteLine("You entered {0}, a valid number", number);

      }
      else
      {
        Console.WriteLine("wrong, please enter a number between 1 and 10");
      }

    }
  }
}
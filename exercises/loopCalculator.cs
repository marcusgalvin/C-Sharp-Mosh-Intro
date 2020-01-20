using System;

//2- Write a program and continuously ask the user to enter a number or "ok" to exit.Calculate the sum of all the previously entered numbers and display it on the console.



namespace loopCalculator
{
  class MainClass
  {
    public static void Main(string[] args)
    {


      Console.WriteLine("please enter a number to be calculated");

      while (true)
      {

        var input = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(input))
        {
          break;

        }
        else
        {
          continue;
        }
        var result = input + input;
        Console.WriteLine(result);

      }


    }
  }
}

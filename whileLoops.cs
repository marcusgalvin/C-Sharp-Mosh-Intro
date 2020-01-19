using System;
//while loops
namespace WhileLoops
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      //check is if the number is divisible by 2
      //for (var i = 1; i <= 10; i++)
      //{
      //    if (i%2 == 0)
      //    {
      //        Console.WriteLine(i);
      //    }
      //}


      //var i = 0;
      //while (i <= 10)
      //{
      //    if (i % 2 == 0)
      //        Console.WriteLine(i);
      //    i++;
      //}


      //use a while loop when you dont know ahead of time how many times you want to iterate, no counter

      while (true)
      {
        Console.Write("type your name: ");
        var input = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(input))
          break;

        Console.WriteLine("@echo: " + input);
      }





    }
  }
}
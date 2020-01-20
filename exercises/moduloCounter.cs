using System;

//1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.


namespace Modulo
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      for (var i = 0; i < 100; i++)
      {
        if (i % 3 == 0)
        {
          Console.WriteLine(i);
        }
      }
    }
  }
}

using System;
using System.Collections.Generic;

namespace Lists
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      var numbers = new List<int>() { 1, 2, 3, 4 };
      numbers.Add(1);
      numbers.AddRange(new int[3] { 5, 6, 7 });

      foreach (var number in numbers)
      {
        Console.WriteLine(number);
      }

      numbers.IndexOf(1);
      Console.WriteLine("index of 1: " + numbers.IndexOf(1);
      Console.WriteLine("last index of 1: " + numbers.LastIndexOf(1);

      Console.WriteLine("count: " + numbers.Count);

      numbers.Remove(1);
      foreach (var number in numbers)
      {
        if (number == 1)
        {
          numbers.Remove(number);
        }
      }
      foreach (var number in numbers)
      {
        Console.WriteLine(number);
      }



    }
  }
}
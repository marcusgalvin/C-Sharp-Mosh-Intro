using System;

namespace Arrays
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      var numbers = new int[3];
      numbers[0] = 1;

      Console.WriteLine(numbers[0]);

      var flags = new bool[3];
      flags[0] = true;

      Console.WriteLine(flags[0]);
      Console.WriteLine(flags[1]);
      Console.WriteLine(flags[2]);

    }
  }
}

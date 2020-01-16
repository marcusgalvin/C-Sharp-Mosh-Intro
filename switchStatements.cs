using System;

namespace SwitchStatements
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      var season = Season.Summer;

      switch (season)
      {
        case
          Season.Autumn:
          Console.WriteLine("It is fall");
          break;

        case Season.Spring:
          Console.WriteLine("It is Spring");
          break;
        case Season.Winter:
          Console.WriteLine("It is winter");
          break;
        case Season.Summer:
          Console.WriteLine("It is summer");
          break;
      }



    }
  }
}
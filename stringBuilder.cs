using System;
using System.Text;

namespace StringsDemo
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      var builder = new StringBuilder();

      builder.Append('-', 10);
      Console.WriteLine(builder);
    }
  }
}
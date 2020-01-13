using System;

namespace Variables
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      //can use var and let c# decide what data type it is
      //hover over the var and it will give you info about the variable
      var number = 2;
      var count = 10;
      float totalPrice = 20.95f;
      char character = 'A';
      string firstName = "mosh";
      bool isWorking = false;

      Console.WriteLine(number);
      Console.WriteLine(count);
      Console.WriteLine(totalPrice);
      Console.WriteLine(character);
      Console.WriteLine(firstName);
      Console.WriteLine(isWorking);
      //Console.WriteLine()

    }
  }
}
using System;

namespace Strings
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      var firstName = "Marcus";
      var lastName = "Galvin";


      //using the Format method
      Console.WriteLine("my name is " + firstName + " " + lastName);
      //notice string.Format makes the code more readable 
      Console.WriteLine("my name is  {0} {1}", firstName, lastName);

      //using the Join method
      var names = new string[3] { "bob", "jim", "joe" };
      var spacedNames = string.Join(",", names);
      Console.WriteLine(spacedNames);

    }
  }
}
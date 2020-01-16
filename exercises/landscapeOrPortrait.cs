using System;

//Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait.

namespace LandscapeOrPortrait
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Please enter a height");
      var height = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Please enter a width");
      var width = Convert.ToInt32(Console.ReadLine());

      if (width > height)
      {
        Console.WriteLine("this photo is landscape");

      }
      else
      {
        Console.Write("this photo is a portrait");
      }

    }
  }
}
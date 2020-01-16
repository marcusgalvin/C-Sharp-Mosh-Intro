using System;

//Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors,
//etc and focus purely on the logic.
//Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.
//If the user enters a value less than the speed limit, program should display Ok on the console.
//If the value is above the speed limit the program should calculate the number of demerit points.
//For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
//If the number of demerit points is above 12, the program should display License Suspended.

namespace speedCamera
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("What is the speed limit?");
      var speedLimit = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("What is the speed of your car?");
      var carSpeed = Convert.ToInt32(Console.ReadLine());

      if (carSpeed <= speedLimit)
      {
        Console.WriteLine("OK");
      }
      else
      {
        Console.WriteLine("You're speeding! For every 5mph over the speed limit you will get 1 demerit point");

      }

      var difference = (carSpeed - speedLimit);

      Console.WriteLine("speed differential: {0}", difference);

      var demeritPoints = difference / 5;
      Console.WriteLine("Amount of demerit points : {0}", demeritPoints);

      if (demeritPoints >= 12)
      {
        Console.WriteLine("Lisence suspended");
      }





    }
  }
}

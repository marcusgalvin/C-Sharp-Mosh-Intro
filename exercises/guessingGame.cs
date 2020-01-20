using System;

//4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
//If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)



namespace GuessingGame
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter a number between 1 and 10");
      var guess = Convert.ToInt32(Console.ReadLine());


      var winningNumber = 5;

      var guessCounter = 0;


      while (guessCounter <= 4)
      {
        if (guess != winningNumber)
        {
          guessCounter++;

          Console.WriteLine("Try again!");
          var guess = Convert.ToInt32(Console.ReadLine());
          continue;
        }
        else if (guess == winningNumber)
        {
          Console.WriteLine("Winner!");
          break;
        }
      }

      //Console.WriteLine("winning number is 5");
    }
  }
}

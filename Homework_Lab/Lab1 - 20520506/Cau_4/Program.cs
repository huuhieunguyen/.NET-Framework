using System;

namespace Lab1_Homework
{
  class Cau4
  {
    static void Main(string[] args)
    {
      string user = "", ans = "";
      // int count = 0;
      // int count1 = 0;

      while (ans != "NO")
      {
        Console.WriteLine("Select any one:\n1->ROCK\n2->PAPER\n3->SCISSOR");
        string[] choices = new string[3] { "ROCK", "PAPER", "SCISSOR" };
        Random rnd = new Random();
        int n = rnd.Next(0, 3);
        do
        {
          Console.WriteLine("Enter your choice:");
          user = Console.ReadLine().ToUpper();
          if (user != "ROCK" && user != "SCISSOR" && user != "PAPER")
          {
            Console.WriteLine("Invalid Entry! Please try again!");
          }
        } while (user != "ROCK" && user != "SCISSOR" && user != "PAPER");

        Console.WriteLine("Computer:" + choices[n]);

        if (user == "ROCK" && choices[n] == "SCISSOR")
        {
          Console.WriteLine("You win!");
        }
        else if (user == "ROCK" && choices[n] == "PAPER")
        {
          Console.WriteLine("Computer wins");
        }
        else if (user == "PAPER" && choices[n] == "ROCK")
        {
          Console.WriteLine("You win!");
        }
        else if (user == "PAPER" && choices[n] == "SCISSOR")
        {
          Console.WriteLine("Computer wins");
        }
        else if (user == "SCISSOR" && choices[n] == "ROCK")
        {
          Console.WriteLine("Computer Wins");
        }
        else if (user == "SCISSOR" && choices[n] == "PAPER")
        {
          Console.WriteLine("You win!");
        }
        else
        {
          Console.WriteLine("Same choices");
        }
        Console.WriteLine("Do u want to continue(YES/NO):");
        ans = Console.ReadLine().ToUpper();
        Console.WriteLine("---------------------------------------");
      }
    }
  }
}
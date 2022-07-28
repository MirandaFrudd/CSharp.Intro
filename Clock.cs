// an inbuilt c# class
using System;

// the container for the classes
namespace CSharp.Intro
{
 // the class
  class Clock
  {
    public void DisplayTime()
    {
        DateTime time = DateTime.Now;
        // void methods can use WriteLine to send info to the terminal, 
        // but void methods cannot be returned
        Console.WriteLine("The current time is {0}", time.ToString("t"));
    }
  }
}
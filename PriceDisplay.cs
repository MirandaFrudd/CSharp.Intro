// an inbuilt c# class
using System;

// the container for the classes
namespace CSharp.Intro
{
 // the class
  class PriceDisplay
  {
    public void Display()
    {
        string item = "Coffee machine";
        double price = 15.99;
        Console.WriteLine("The price of the item {0} is {1}", item, price);
    }
  }
}
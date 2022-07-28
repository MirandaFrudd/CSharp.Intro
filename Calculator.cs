using System;

namespace CSharp.Intro
{
  class Calculator
  {
    // what does this method return?
    public void Calculate()
    {
      // note that the we have to declare a type (int) for the variable (result)
      // int result = 2 + 2;

      double result = 2.5 + 2.5;

      // if we used the line below, it would throw a compile error
      // string result = 2 + 2;
      Console.WriteLine("The result is {0}", result);
      // decimal
      Console.WriteLine("The result is {0:n}", result);
    }
  }
}
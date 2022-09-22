using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace sampleDotNet
{
    class MathRelated
    {
      // Fibonacci numbers with yield which does not store the collection of series
      // Yield only stores the current state before moving onto next state
      public static IEnumerable<int> Fibonacci()
      {
        int first = 0;
        int second = 1;
        yield return first;
        yield return second;
        //the 46th fibonacci number is the largest that
        //can be represented in 32 bits. 
        for (int i = 2; i < 47; i++)
        {
          int retVal = first+second;
          first=second;
          second=retVal;
          yield return retVal;
        }
      }

      // Fibonacci numbers recursively
      public static void FibonacciSeries(int firstNumber, int secondNumber, int counter, int numberOfSeq)
      {
        Console.Write(firstNumber + " ");
        if (counter < numberOfSeq)
        {
          FibonacciSeries(secondNumber, firstNumber + secondNumber, counter + 1, numberOfSeq);
        }
      }

    public static void FibonacciIterate(int firstNumber, int secondNumber, int numberOfSeq)
    {
      //First print first and second number
      Console.Write(firstNumber + " " + secondNumber + " ");
      int nextNumber = 0;
      //Starts the loop from 2 because 0 and 1 are already printed
      for(int i = 2; i < numberOfSeq; i++)
      {
          nextNumber = firstNumber + secondNumber;
          Console.Write(nextNumber + " ");
          firstNumber = secondNumber;
          secondNumber = nextNumber;
      }
    }
  }
}
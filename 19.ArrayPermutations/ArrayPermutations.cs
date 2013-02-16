using System;
using System.Collections.Generic;

class ArrayPermutations
{
    static void SwapValues<T>(T[] arr, int startPos, int endPos)            //Here we will swap the values of the array.
    {
        if (startPos != endPos)
        {
            T temporary = arr[startPos];                                    //We need this to keep the value from the starting position.
            arr[startPos] = arr[endPos];
            arr[endPos] = temporary;
        }
    }
    static IEnumerable<T[]> Permutations<T>(T[] arr, int startIndex = 0)    //Here we will calculate the permutations with an iterator method.
    {
        if (startIndex + 1 == arr.Length)
        {
            yield return arr;                                              //We use a yield return statement to return each element one at a time.
        }
        else
        {
            foreach (var item in Permutations(arr, startIndex + 1))        //We go to the next value.
            {
                yield return item;
            }
            for (var i = startIndex + 1; i < arr.Length; i++)              //In the loop we use the swapping method to change position of the values.
            {
                SwapValues(arr, startIndex, i);
                foreach (var item in Permutations(arr, startIndex + 1))
                {
                    yield return item;
                }
                SwapValues(arr, startIndex, i);
            }
        }
    }
    static void Main()
    {
        Console.Write("Enter a number N to make permutations:");
        int N = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[N];
        for (int i = 1; i <= N; i++)
        {
            arrayOfNumbers[i - 1] = i;
        }

        foreach (var item in Permutations(arrayOfNumbers))
        {
            Console.WriteLine(string.Join(", ", item));
        }
    }
}

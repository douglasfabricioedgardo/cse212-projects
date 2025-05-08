//authot: douglas fabricio ramirez
//date: 05/05/2025
using System;
using System.Collections.Generic;
public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
   public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create a new array of doubles with the specified 'length'
        double[] multiples = new double[length];

        // Step 2: Loop through the array indices from 0 to length - 1
        for (int i = 0; i < length; i++)
        {
            // Step 3: For each index, calculate the multiple by multiplying 'number' by (i + 1)
            // Step 4: Store the result at index 'i' of the array
            multiples[i] = number * (i + 1);
            multiples[i] = number * (i + 1);  // Multiplicamos el número por el índice + 1 para obtener los múltiplos
        }
        // Step 5: Return the filled array of multiples

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
          // Step 1: Ensure 'amount' is within the bounds of the list size
        // This handles cases where 'amount' might be equal to or greater than data.Count
        amount = amount % data.Count;

        // Step 2: Get a sublist of the last 'amount' elements from the original list
        List<int> end = data.GetRange(data.Count - amount, amount); // Los últimos 'amount' elementos
                // Step 3: Get a sublist of the remaining elements at the beginning of the list

        List<int> start = data.GetRange(0, data.Count - amount);    // El resto de la lista

        // Step 4: Clear the original list to prepare for inserting rotated elements

        data.Clear();

        // Step 5: Add the end segment first (rotated part)
        data.AddRange(end);
        // Step 6: Add the start segment after the rotated part

        data.AddRange(start);
    }
}
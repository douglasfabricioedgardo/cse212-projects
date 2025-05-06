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
        // Creamos un array de tamaño 'length'
        double[] multiples = new double[length];

        // Llenamos el array con los múltiplos de 'number'
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);  // Multiplicamos el número por el índice + 1 para obtener los múltiplos
        }

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
        // Primero, aseguramos que el amount no sea mayor que el tamaño de la lista
        amount = amount % data.Count;

        // Obtenemos dos segmentos: el final de la lista y el inicio
        List<int> end = data.GetRange(data.Count - amount, amount); // Los últimos 'amount' elementos
        List<int> start = data.GetRange(0, data.Count - amount);    // El resto de la lista

        // Limpiamos la lista original
        data.Clear();

        // Agregamos los segmentos en el nuevo orden
        data.AddRange(end);
        data.AddRange(start);
    }
}
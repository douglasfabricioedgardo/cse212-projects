using System;

public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4 };
        var l2 = new[] { 10, 20, 30, 40 };
        var select = new[] { 1, 1, 2, 2, 1, 1, 2, 2 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}");
        // Salida esperada: <int[]>{1, 2, 10, 20, 3, 4, 30, 40}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int[] result = new int[select.Length];
        int pos_list1 = 0, pos_list2 = 0;

        for (int i = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
            {
                result[i] = list1[pos_list1];
                pos_list1++;
            }
            else if (select[i] == 2)
            {
                result[i] = list2[pos_list2];
                pos_list2++;
            }
            else
            {
                throw new ArgumentException("Selector list only accepts 1 or 2.");
            }
        }

        return result;
    }
}

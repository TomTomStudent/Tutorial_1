using System;

public class Main
{
    public static int FindMax(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be empty");
        }
        int checkConflictVariable = numbers[0];
        foreach (int num in numbers)
        {
            if (num > checkConflictVariable)
            {
                checkConflictVariable = num;
            }
        }
        return checkConflictVariable;
    }
}
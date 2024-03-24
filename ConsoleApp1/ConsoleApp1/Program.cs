using System;

public class Main
{
    public static int FindMax(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be empty");
        }
        int notWhatItShouldBe = numbers[0];
        foreach (int num in numbers)
        {
            if (num > notWhatItShouldBe)
            {
                notWhatItShouldBe = num;
            }
        }
        return notWhatItShouldBe;
    }
}
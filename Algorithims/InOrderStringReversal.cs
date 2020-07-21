using System;

public class InOrderStringReversal
{
    public static String InOrderReverse(String words)
    {
        if(words == null)
        {
            return null;
        }
        var letters = words.ToCharArray();

        Reverse(letters, 0, letters.Length - 1);

        int pointer = 0;
        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] == ' ' && i != pointer)
            {
                Reverse(letters, pointer, i - 1);
                pointer = i + 1;
            }
            else if (letters[i] == ' ' && i == pointer)
            {
                pointer = i + 1;
            }
        }
        Reverse(letters, pointer, letters.Length - 1);

        return new String(letters);
    }

    private static void Reverse(char[] letters, int start, int end)
    {
        if (letters != null)
        {
            var frontPointer = start;
            var backPointer = end;

            while (frontPointer < backPointer)
            {
                swap(letters, frontPointer, backPointer);
                backPointer--;
                frontPointer++;
            }
        }
    }

    private static void swap(char[] letters, int index1, int index2)
    {
        var temp = letters[index2];
        letters[index2] = letters[index1];
        letters[index1] = temp;
    }
}

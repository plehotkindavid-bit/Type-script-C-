using System;

int[] array = { 8, 15, 22, 7, 10 };

int min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine("Минимальное число: " + min);


   

// Задача 41: Пользователь вводит с клавиатуры числа через запятую. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  0, 7, 8, -2, -2 -> 2 -1, -7, 567, 89, 223-> 3

using System.Threading.Tasks.Dataflow;

using System;
using static System.Console;

WriteLine("Write number, ");
int[] numbers = StringToNum(ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
WriteLine();
WriteLine($"ALl number point > 0 = {sum}");


int[] StringToNum(string input)
{
    int con = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            con++;
        }
    }

    int[] numbers = new int[con];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input[i] != ',')
        {
            if (i != input.Length - 1)
            {
                temp += input[i].ToString();
                i++;
            }
            else
            {
                temp += input[i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    WriteLine("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        WriteLine(array[i] + " ");
    }
    WriteLine("]");
}
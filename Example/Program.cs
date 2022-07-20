/*
Написать программу, которая из имеющегося массива 
строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоночальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
*/

string[] FirstArray = new string[6] {"-=/", "13", "666", "fg", "e56789-", "dfgdfgdg"};
string[] SecondArray = new string[FirstArray.Length];

void GetArraysecond(string[] FirstArray, string[] SecondArray)
{
    int count = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
        if (FirstArray[i].Length <= 3)
        {
            SecondArray[count] =  FirstArray[i];
            count ++;
        }
    }
}

void PrintArray(string[] SecondArray)
{
    for (int i = 0; i < SecondArray.Length; i++)
    {
        Console.Write($"{SecondArray[i]} ");
    }
    Console.WriteLine();
}

GetArraysecond(FirstArray, SecondArray);
Console.WriteLine("Изночальный массив ");
PrintArray(FirstArray);
Console.WriteLine("Полученный массив ");
PrintArray(SecondArray);
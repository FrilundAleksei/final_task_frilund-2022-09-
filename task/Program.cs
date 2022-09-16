
using static System.Console;
Clear();

WriteLine($"Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.");
WriteLine();
string[] array1 = new string[8] {"123", "23", "hello", "world", "res", "geek", "Git", "Hu2"};
WriteLine($"Заданный массив: [{String.Join(",", array1)}]");
string[] array2 = new string[array1.Length];
NewArray(array1, array2);
WriteLine();
//WriteLine($"Обновленный массив:");
//PrintArray(array2);
WriteLine($"Массив из элементов сосответствующих увловию: [{String.Join(",", array2)}]");
WriteLine();

void NewArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}


//
//void PrintArray(string[] array)
//{
//    Write("[");
//    for (int i = 0; i < array.Length; i++)
//    {
//      Write($"{array[i]},");
//    }
//    Write("]");
//    WriteLine();
//}
//
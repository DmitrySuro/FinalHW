/*Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3
символам. Первоначальный массив можно ввести с клавиатуры, либо задать на 
старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
*/

System.Console.Clear();

string[] FillArray(string[] array)
{
    string userString = string.Empty;
    
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine("Заполните массив ");
        userString = Console.ReadLine()!;
        array[i] = userString;
    }
    
    return array;
}

string[] SampleFromFillArray(string[] array, int sizesSampleArray)
{
    string numbersOfCharcter = string.Empty;
    
    for (int i = 0; i < array.Length; i++)
    {
        numbersOfCharcter = array[i];
        if (numbersOfCharcter.Length <= 3)
        {
            sizesSampleArray += 1;
        }
    }
    
    int j = 0;
    string[] sampleArray = new string[sizesSampleArray];
    
    for (int i = 0; i < array.Length; i++)
    {
        numbersOfCharcter = array[i];
        if (numbersOfCharcter.Length <= 3)
        {
            sampleArray[j] = array[i];
            j++;
        }
    }

    return sampleArray;
}

System.Console.WriteLine("Введите размер массива");
int sizeArray = int.Parse(Console.ReadLine()!);
int sizesSampleArray = 0;

string[] array = new string[sizeArray];
array = FillArray(array);

string[] sampleArray = new string[sizesSampleArray];
sampleArray = SampleFromFillArray(array,sizesSampleArray);

System.Console.WriteLine("Изначальный массив");
System.Console.WriteLine("[" + string.Join(", ", array) + "]");

System.Console.WriteLine("Собранный по условию массив");
System.Console.WriteLine("[" + string.Join(", ", sampleArray) + "]");


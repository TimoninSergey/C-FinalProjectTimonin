/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями.
*/

 string[] CreateStringArray()
 {
    Console.WriteLine("Введите количество элементов массива");
    int n = Convert.ToInt32(Console.ReadLine());

    string[] array = new string[n];
    for (int i = 0; i < array.Length; i++)
    {
      Console.WriteLine($"Введите элемент массива номер {i}");
      array[i] = Console.ReadLine();
    }

    return array;
 }

 int ElementNumberCount(string[] arr)
 {
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i].Length < 4) count++;
    }
    return count;
 }

 string[] CreateNewArray(int number, string[] arr)
 {
  string[] newArray = new string[number];
  int k = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i].Length < 4) 
    {
      newArray[k] = arr[i];
      k++;
    }
  }
  return newArray;
 }

 void PrintStringArray(string[] arr)
 {
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write ($"{arr[i]},  ");
  }
 }

 string[] array = CreateStringArray();

 PrintStringArray(CreateNewArray(ElementNumberCount(array), array));
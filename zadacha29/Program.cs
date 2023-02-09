// Напишите программу, которая задаёт м
// ассив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();
// Console.Write("Введите число ");
// int n = int.Parse (Console.ReadLine());
int n = 8;
int [] array = GetDecArray(n);
Console.WriteLine($"[{String.Join(", ", array)}]"); // у библиотеки string есть метод Join
// он объединяет массив array строкой которую введем в параметр (", ")
int [] GetDecArray (int n)
{
  int [] result = new int [n]; // создали массив на size элементов
  for (int i = 0; i < n; i++)
  {
    result [i] = new Random().Next(100); // на каждый элемент массива кладем рандомное число2 значит будет 0 и 1
  }
  return result;
}
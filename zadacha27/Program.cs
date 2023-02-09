// // Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число ");
int n = int.Parse (Console.ReadLine());
Console.WriteLine($"Сумма числа {n} равна {GetSuma(n)}");
 
 int GetSuma (int n)
 {
  int sum = 0;
  int result = 0;
  if (n<0)
  n *= (-1);
 for (int i = 1; n>0; i++)
 {
  result = n%10;
  sum = sum + result;
  n=n/10;
 }
 return sum;
 }

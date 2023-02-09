//  Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит 
//число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число  ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите степень ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine($"{A} ^ {B} = {GetPower(A)}");

int GetPower (int A)
{
 int Power = 1;
 for (int i=1; i<=B; i++)
 {
  Power *= A;
 }
 return Power;
}  
 

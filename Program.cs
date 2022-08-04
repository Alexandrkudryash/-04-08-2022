// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// вывести все четные числа от 1 до N

Console.WriteLine("введите число");

int N = int.Parse(Console.ReadLine());

int a=0;
while (a < N) 
{
if (a%2==0)
    {
    Console.WriteLine(a);
        }
    a=a+1;
}

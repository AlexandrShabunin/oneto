//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

console.Write("ввести первое число:");
int number1 = int.Parse(Console.ReadLine());
console.Write("ввести второе число:");
int number2 = int.Parse(console.ReadLine());
console.Write("ввести nhtnmt число:");
int number3 = int.Parse(console.ReadLine());

int max = numder1;
if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}
Console.WriteLine("максимальное число=max");


//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

console.Write("введите число: ");
int number = int.Parse(console.ReadLine());
if (number % 2 == 0)
{
    console.WriteLine("число четное");
}
else
{
    console.WriteLine("число нечетное");
}
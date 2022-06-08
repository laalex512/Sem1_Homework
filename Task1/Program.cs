/*Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.*/

Console.WriteLine("Insert a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert b:");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    Console.WriteLine("a ("+a+") bigger then b");
}
else if (a<b)
{
    Console.WriteLine("b ("+b+") bigger then a");
}
else Console.WriteLine("the numbers a and b are equal");

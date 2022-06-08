/* Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.*/

Console.WriteLine("Insert N:");
int number = Convert.ToInt32(Console.ReadLine());
int printNumber = 2;
if (printNumber>number) Console.WriteLine("None");
while (printNumber <= number)
{
    Console.Write(printNumber + "  ");
    printNumber += 2;
}
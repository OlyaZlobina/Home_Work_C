// Программа, которая на вход принимает 2 числа и выдает, какое число больше, а какое меньше.
Console.WriteLine("Input first number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int B = Convert.ToInt32(Console.ReadLine());
if (A > B)
{
    Console.Write("First number is more, second number is less  ");
}
else
    Console.WriteLine("Second number is more, first number is less  ");
// Программа, которая на вход принимает 2 числа и выдает, какое число больше, а какое меньше.
//Console.WriteLine("Input first number: ");
//int A = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input second number: ");
//int B = Convert.ToInt32(Console.ReadLine());
//if (A > B)
//{
    //Console.Write("First number is more, second number is less  ");
//}
//else
    //Console.WriteLine("Second number is more, first number is less  ");

// Программа, которая принимает 3 числа и выдает максимальное из них.
Console.Write("Input first number: ");  
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
    if(num1 > num2){
    Console.WriteLine("First number is maximum ");
} 
else
    if (num2 > num3){
    Console.WriteLine("Second number is maximum ");
}
else    
    if (num3 > num1){
    Console.WriteLine("Third number is maximum");
}


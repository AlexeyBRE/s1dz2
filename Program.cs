//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());
if (b<a)
{
    if(a>c)
    Console.WriteLine($"{a}==max");
};

if (a<b)
{
    if(b>c)
Console.WriteLine($"{b}==max");
};
if (a<c){
    if(c>b)
    Console.WriteLine($"{c}==max");
};

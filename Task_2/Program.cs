// Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно
// числу 1, то программа выводит остаток от деления.

Console.WriteLine("Введите первое число: ");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numTwo = Convert.ToInt32(Console.ReadLine());

if(numOne % numTwo == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Остаток от деления {numOne % numTwo}");
}
// напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа

int randomNum = new Random().Next(100, 1000);
Console.WriteLine(randomNum);

int num = (randomNum / 100) * 10 + randomNum % 10;
Console.WriteLine(num);
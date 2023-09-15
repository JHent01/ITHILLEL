
using System;

Random random = new Random();
int randomNum = random.Next(1, 146);
int num;
Console.WriteLine("Введіть число:");
do
{
    int inNum = int.Parse(Console.ReadLine());
    if (randomNum > inNum)
    {
        Console.WriteLine("Число більше");
    }
    else if (randomNum < inNum) Console.WriteLine("Число меньше");
    else Console.WriteLine("Вірно");
    num = inNum;
}
while (randomNum != num);

   
Console.ReadLine();
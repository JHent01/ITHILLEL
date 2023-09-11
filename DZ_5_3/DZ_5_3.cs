//4.перевірка чи є введене натуральне число простим


Random random = new Random();
int gennum = random.Next(2, 1000);



 bool CheckNum(int i, bool indikator)
{
    
    for (i = 2; i < gennum; i++)
    {
        if (gennum % i == 0)
        {
            return indikator = false;
        }
        else return indikator = true;
    }
    return indikator;
 }

if (CheckNum(2,false)) Console.WriteLine("not simple");
else Console.WriteLine("simple"); 



Console.ReadLine();
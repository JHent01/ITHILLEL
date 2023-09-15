
Random rand = new Random();

int[] randNumbers = new int[20];

for (int i = 0; i < randNumbers.Length; i++)
{
    randNumbers[i] = rand.Next(, 100);
}



PrintMass(randNumbers);

void PrintMass(int[] longArray)
{
    foreach (int i in longArray)
    {
        Console.WriteLine(i);
    }
}


//Console.ReadKey();


//for (int i = 0; i < randNumbers.Length; i++)
//{
//    randNumbers[int.Purse(ReadLine())] = 00    
//}



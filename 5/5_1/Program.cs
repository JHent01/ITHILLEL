string chek, pass = "root";
Console.Write("Send password:");

chek = Console.ReadLine();
while (chek != pass)
{
    Console.WriteLine($"Password {chek} don`t true");
    chek = Console.ReadLine();
}


Console.WriteLine("Password true");
Console.ReadKey();

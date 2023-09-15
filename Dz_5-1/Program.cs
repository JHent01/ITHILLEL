
Console.Write("Введіть пароль:");

string chek = Console.ReadLine();
string pass = "root";
string ChekPass(string chek )
{
    

    while (chek != pass)
    {
        Console.WriteLine($"password {chek} don`t wrong");
    }

    return chek;

}








Console.ReadLine();
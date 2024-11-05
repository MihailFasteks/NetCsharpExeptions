// See https://aka.ms/new-console-template for more information
using NetCsharpExeptions;
//task1
//CreditCard card1 = new CreditCard("1234567891234567", "11111", "11111", "11111", "111111", "10.10.10.10"); ;

//task2
Console.WriteLine("Input ");
string input=Console.ReadLine();
input.Replace(" ","");
string tempnum = "";
int res = 1;

try
{
    for (int i = 0; i < input.Length; i++)
    {
    if (input[i] != '*')
    {
        tempnum += input[i];
    }
    if (input[i] == '*' || i == input.Length - 1)
    {
        res *= int.Parse(tempnum);
        tempnum = "";
    }
        if (char.IsDigit(input[i]) == false && input[i] != '*')
        {
            throw new Exception("Wrong symbol");
        }
    }
    Console.WriteLine(res);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}



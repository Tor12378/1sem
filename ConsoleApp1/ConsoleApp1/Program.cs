// See https://aka.ms/new-console-template for more information
/*double x = double.Parse(Console.ReadLine());
double res = 0;
int pow = 10;
int per = 1;
double tmp = 0;
for(int i = 0; i < 10; i++)
{
   
    res += Math.Pow(x, pow) * per;
    per += 1;
    pow -= 1;
}
Console.WriteLine(res);
*/
/*double x = double.Parse(Console.ReadLine());
double y = 0;

int i = 10;
double tmp = x;
while (i > 0)
{
    y = y + Math.Cos(tmp);
    tmp *= x;
    i--;
}
Console.WriteLine(y);
*/
using System.Diagnostics.CodeAnalysis;

 static double Calculate(string userInput)
{
    string[] data = userInput.Split(' ');
    double amountOfMoney = double.Parse(data[0]);
    double rate = double.Parse(data[1]);
    double numberOfMonths = double.Parse(data[2]);
    double allRate = (Math.Pow(1+rate/1200, numberOfMonths));
  
    return allRate * amountOfMoney;

}
Console.WriteLine(Calculate("1000,1 1,2 1"));

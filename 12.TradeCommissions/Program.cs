//Input
string city = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());


//Calculations
double commision = -1;
if (sales >= 0)
{
  if (city == "Sofia")
  {
    if (sales >= 0 && sales <= 500)
    {
      commision = sales * 0.05;
    }
    else if (sales > 500 && sales <= 1000)
    {
      commision = sales * 0.07;
    }
    else if (sales > 1000 && sales <= 10000)
    {
      commision = sales * 0.08;
    }
    else if (sales > 10000)
    {
      commision = sales * 0.12;
    }
  }
  else if (city == "Varna")
  {
    if (sales >= 0 && sales <= 500)
    {
      commision = sales * 0.045;
    }
    else if (sales > 500 && sales <= 1000)
    {
      commision = sales * 0.075;
    }
    else if (sales > 1000 && sales <= 10000)
    {
      commision = sales * 0.10;
    }
    else if (sales > 10000)
    {
      commision = sales * 0.13;
    }
  }
  else if (city == "Plovdiv")
  {
    if (sales >= 0 && sales <= 500)
    {
      commision = sales * 0.055;
    }
    else if (sales > 500 && sales <= 1000)
    {
      commision = sales * 0.08;
    }
    else if (sales > 1000 && sales <= 10000)
    {
      commision = sales * 0.12;
    }
    else if (sales > 10000)
    {
      commision = sales * 0.145;
    }
  }
}

//Output
if (commision >= 0)
{
  Console.WriteLine($"{commision:f2}");
}
else
{
  Console.WriteLine("error");
}



/*Търговски комисионни
Фирма дава следните комисионни на търговците си според града, в който работят и обема на продажбите:
Град
0 ≤ s ≤ 500
500 < s ≤ 1 000
1 000 < s ≤ 10 000
s > 10 000
Sofia
5%
7%
8%
12%
Varna
4.5%
7.5%
10%
13%
Plovdiv
5.5%
8%
12%
14.5%

Напишете конзолна програма, която чете име на град (стринг) и обем на продажби (реално число) , въведени от 
потребителя, и изчислява и извежда размера на търговската комисионна според горната таблица. Резултатът да се изведе
форматиран до 2 цифри след десетичната точка. При невалиден град или обем на продажбите (отрицателно число) да се 
отпечата "error". 
Примерен вход и изход
вход
изход


вход
изход


вход
изход


вход
изход
Sofia
1500
120.00
Plovdiv
499.99
27.50
Varna
3874.50
387.45
Kaspichan
-50
error

*/
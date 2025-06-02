//Input
string product = Console.ReadLine();
string city = Console.ReadLine();
double count = double.Parse(Console.ReadLine());

//Calculations
switch (product)
{
  case "coffee":
    switch (city)
    {
      case "Sofia":
        double priceSofia = count * 0.50;
        Console.WriteLine(priceSofia);
        break;
      case "Plovdiv":
        double pricePlovdiv = count * 0.40;
        Console.WriteLine(pricePlovdiv);
        break;
      case "Varna":
        double priceVarna = count * 0.45;
        Console.WriteLine(priceVarna);
        break;
    }
    break;
  case "water":
    switch (city)
    {
      case "Sofia":
        double priceSofia = count * 0.80;
        Console.WriteLine(priceSofia);
        break;
      case "Plovdiv":
        double pricePlovdiv = count * 0.70;
        Console.WriteLine(pricePlovdiv);
        break;
      case "Varna":
        double priceVarna = count * 0.70;
        Console.WriteLine(priceVarna);
        break;
    }
    break;
  case "beer":
    switch (city)
    {
      case "Sofia":
        double priceSofia = count * 1.20;
        Console.WriteLine(priceSofia);
        break;
      case "Plovdiv":
        double pricePlovdiv = count * 1.15;
        Console.WriteLine(pricePlovdiv);
        break;
      case "Varna":
        double priceVarna = count * 1.10;
        Console.WriteLine(priceVarna);
        break;
    }
    break;
  case "sweets":
    switch (city)
    {
      case "Sofia":
        double priceSofia = count * 1.45;
        Console.WriteLine(priceSofia);
        break;
      case "Plovdiv":
        double pricePlovdiv = count * 1.30;
        Console.WriteLine(pricePlovdiv);
        break;
      case "Varna":
        double priceVarna = count * 1.35;
        Console.WriteLine(priceVarna);
        break;
    }
    break;
  case "peanuts":
    switch (city)
    {
      case "Sofia":
        double priceSofia = count * 1.60;
        Console.WriteLine(priceSofia);
        break;
      case "Plovdiv":
        double pricePlovdiv = count * 1.50;
        Console.WriteLine(pricePlovdiv);
        break;
      case "Varna":
        double priceVarna = count * 1.55;
        Console.WriteLine(priceVarna);
        break;
    }
    break;

}


//Output




/*Квартално магазинче
Предприемчив българин отваря квартални магазинчета в няколко града и продава на различни цени според града:
град / продукт
coffee
water
beer
sweets
peanuts
Sofia
0.50
0.80
1.20
1.45
1.60
Plovdiv
0.40
0.70
1.15
1.30
1.50
Varna
0.45
0.70
1.10
1.35
1.55

Напишете програма, която чете продукт (низ), град (низ) и количество (десетично число), въведени от потребителя,
и пресмята и отпечатва колко струва съответното количество от избрания продукт в посочения град. 
Примерен вход и изход
вход
изход


вход
изход


вход
изход


вход
изход


вход
изход
coffee
Varna
2
0.9
peanuts
Plovdiv
1
1.5
beer
Sofia
6
7.2
water
Plovdiv
3
2.1
sweets
Sofia
2.23
3.2335

*/
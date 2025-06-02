//Input
int time = int.Parse(Console.ReadLine());
string day = Console.ReadLine();

//Calculations
if (day == "Sunday")
{
  Console.WriteLine("closed");
}
else
{
  if (time >= 10 && time <= 18)
  {
    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday")
    {
      Console.WriteLine("open");
    }
    else
    {
      Console.WriteLine("closed");
    }
  }
  else
  {
    Console.WriteLine("closed");
  }
}


//Output



/* Работно време
Да се напише програма, която чете час от денонощието(цяло число) и ден от седмицата(текст) - въведени от потребителя
и проверява дали офисът на фирма е отворен, като работното време на офисът е от 10-18 часа, от понеделник до събота
включително
Примерен вход и изход
вход
изход


вход
изход
 
вход
изход
11
Monday
open
19
Friday
closed
11
Sunday
closed


*/
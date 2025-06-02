//Input
string day = Console.ReadLine();

//Calculations


//Output
switch (day)
{
  case "Monday":
  case "Tuesday":
  case "Wednesday":
  case "Thursday":
  case "Friday":
    Console.WriteLine("Working day");
    break;
  case "Saturday":
  case "Sunday":
    Console.WriteLine("Weekend");
    break;
  default:
    Console.WriteLine("Error");
    break;
}


/* Напишете програма която, чете ден от седмицата (текст), на английски език - въведен от потребителя.Ако денят е работен 
 * отпечатва на конзолата - "Working day", ако е почивен - "Weekend". Ако се въведе текст различен от ден от седмицата
 * да се отпечата - "Error".

Примерен вход и изход
Вход
Изход
Monday
Working day


Вход
Изход
Sunday
Weekend


Вход
Изход
April
Error


Насоки
Прочетете ден от седмицата(текст) от конзолата:

Отпечатайте работен или почивен ден,според въведения ден, ако денят е невалиден отпечатайте "Error":


*/
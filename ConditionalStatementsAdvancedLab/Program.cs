//Input
int day = int.Parse(Console.ReadLine());

//Calculations


//Output
switch (day)
{
  case 1:
    Console.WriteLine("Monday");
    break;
    case 2:
    Console.WriteLine("Tuesday");
    break;
    case 3:
    Console.WriteLine("Wednesday");
    break;
    case 4:
    Console.WriteLine("Thursday");
    break;
    case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
  default:
    Console.WriteLine("Error");
    break;
}


/*Ден от седмицата
Напишете програма, която чете цяло число, въведено от потребителя, и отпечатва ден от седмицата (на английски език),
в граници [1...7] или отпечатва "Error" в случай, че въведеното число е невалидно. 
Примерен вход и изход
Вход
Изход
1
Monday
2
Tuesday
3
Wednesday
4
Thursday
5
Friday
6
Saturday
7
Sunday
-1
Error

Насоки
Създайте нов проект в съществуващото Visual Studio решение. В Solution Explorer кликнете с десен бутон на мишката върху
Solution реда и изберете [Add] 🡪 [New Project…]:

Ще се отвори диалогов прозорец за избор на тип проект за създаване. Изберете C# конзолно приложение и задайте подходящо
име, например "DayOfWeek":
 
Вече имате solution с едно конзолно приложение в него. Остава да напишете кода за решаване на задачата.
Прочетете едно цяло число от конзолата:
 
Отпечатайте денят от седмицата според въведеното число. Ако то е невалидно, отпечатайте "Error".
 
*/
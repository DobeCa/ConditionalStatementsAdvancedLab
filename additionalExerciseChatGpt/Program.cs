//Input
int grade = int.Parse(Console.ReadLine());


//Calculations


//Output
switch (grade)
{
  case int n when n == 6:
    Console.WriteLine("Отличен!");
    break;
  case int n when n == 5:
    Console.WriteLine("Много добър!");
    break;
  case int n when n == 4:
    Console.WriteLine("Добър!");
    break;
  case int n when n == 3:
    Console.WriteLine("Среден!");
    break;
  case int n when n == 2:
    Console.WriteLine("Слаб!");
    break;
    default:
    Console.WriteLine("Невалидна оценка");
    break;

}



/*Упражнение: Оценка в училище
Задача:
Напиши програма, която приема цяло число от потребителя (оценка от 2 до 6) и отпечатва:

Оценка	Описание
6	"Отличен!"
5	"Много добър!"
4	"Добър!"
3	"Среден!"
2	"Слаб!"
Друго	"Невалидна оценка"

🧾 Вход:
csharp
Копиране
Редактиране
int grade = int.Parse(Console.ReadLine());
🎯 Изход:
Използвай switch с case int n when n == ... и отпечатай текста според оценката.

💡 Пример:
Вход:

Копиране
Редактиране
5
Изход:

Копиране
Редактиране
Много добър!
📌 Твоята задача: Напиши кода с switch и when.*/
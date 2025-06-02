//Input
int grade = int.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());

//Calculations


//Output
switch (grade)
{
  case int gr when gr == 6:
    Console.WriteLine(gender == 'm' ? "Отличен, господин!" : "Отлична, госпожице!");
    break;
  case int gr when gr == 5:
    Console.WriteLine(gender == 'm' ? "Много добър, господин!" : "Много добра, госпожице!");
    break;
  case int gr when gr == 4:
    Console.WriteLine(gender == 'm' ? "Добър, господин!" : "Добра, госпожице!");
    break;
  case int gr when gr == 3:
    Console.WriteLine(gender == 'm' ? "Среден, господин!" : "Средна, госпожице!");
    break;
  case int gr when gr == 2:
    Console.WriteLine(gender == 'm' ? "Слаб, господин!" : "Слаба, госпожице!");
    break;
  default:
    Console.WriteLine("Невалидна оценка!");
    break;

}

/* Задача: Оценка и пол на ученик
Напиши програма, която приема:
цяло число grade (от 2 до 6)
символ gender (m или f)
Програмата трябва да отпечата подходящо съобщение, като използваш вложен switch – първо по оценка, после по пол.
Оценка	Пол	Резултат
6	m	Отличен, господин!
6	f	Отлична, госпожице!
5	m	Много добър, господин!
5	f	Много добра, госпожице!
4	m	Добър, господин!
4	f	Добра, госпожице!
...	...	и т.н. до 2
Друго	-	Невалидна оценка!

🧾 Вход:
int grade = int.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());
🎯 Изход:
Текст според таблицата по-горе.
💡 Подсказки:
Използвай switch (grade) с case int g when g == ...
Във всеки case вложи втори switch (gender)
Ползвай Console.WriteLine(...) с подходящо съобщение.*/
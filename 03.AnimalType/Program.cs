//Input
string animal = Console.ReadLine();

//Calculations


//Output
switch (animal)
{
  case "dog":
    Console.WriteLine("mammal");
    break;
  case "crocodile":
  case "tortoise":
  case "snake":
    Console.WriteLine("reptile");
    break;
  default:
    Console.WriteLine("unknown");
    break;
}


/*Клас животно
Напишете програма, която отпечатва класа на животното според неговото име, въведено от потребителя.
dog -> mammal
crocodile, tortoise, snake -> reptile
others -> unknown
Примерен вход и изход
Вход
Изход
dog
mammal
snake
reptile
cat
unknown

Насоки
Прочетете входните данни:
 
Проверете от какъв вид е животното. Ако то е невалидно, отпечатайте "unknown".
 
*/
//Input
string product = Console.ReadLine();

//Calculations
if (product == "banana" || product == "apple" || product == "kiwi" || product == "cherry" || product == "lemon" || product == "grapes")
{
  Console.WriteLine("fruit");
}
else if (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot")
{
  Console.WriteLine("vegetable");
}
else
{
  Console.WriteLine("unknown");
}


//Output



/*Плод или зеленчук
Да се напише програма, която чете име на продукт, въведено от потребителя, и проверява дали е плод или зеленчук.
Плодовете "fruit" имат следните възможни стойности:  banana, apple, kiwi, cherry, lemon и grapes
Зеленчуците "vegetable" имат следните възможни стойности:  tomato, cucumber, pepper и carrot
Всички останали са "unknown"Да се изведе "fruit”, "vegetable" или "unknown" според въведения продукт.
Примерен вход и изход
вход
изход


вход
изход


вход
изход


вход
изход
banana
fruit
apple
fruit
tomato
vegetable
water
unknown

*/
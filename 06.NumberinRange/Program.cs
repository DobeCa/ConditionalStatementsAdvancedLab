//Input
double number = double.Parse(Console.ReadLine());

//Calculations


//Output
if (number != 0 && number >= -100 && number <= 100)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}



/*Число в интервалa
Да се напише програма, която проверява дали въведеното от потребителя число е в интервала [-100, 100] и е различно 
от 0 и извежда "Yes", ако отговаря на условията, или "No" ако е извън тях.
Примерен вход и изход
вход
изход
-25
Yes
0
No
25
Yes

*/
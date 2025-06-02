using System;

class Program
{
  static void Main(string[] args)
  {
    double age = double.Parse(Console.ReadLine());
    string gender = Console.ReadLine();

    switch (age)
    {
      case double n when n >= 16:
        switch (gender)
        {
          case "m":
            Console.WriteLine("Mr.");
            break;
          case "f":
            Console.WriteLine("Ms.");
            break;
        }
        break;

      case double n when n < 16:
        switch (gender)
        {
          case "m":
            Console.WriteLine("Master");
            break;
          case "f":
            Console.WriteLine("Miss");
            break;
        }
        break;
    }
  }
}

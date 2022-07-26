using System;

enum Priority
{
    High,
    Normal,
    Low
}

enum Animal
{
    Horse,
    Sheep = 5,
    Monkey
}

/*
namespace EnumSwitch
{


    class EnumerationDemo
    {
        static void Main()
        {

            Priority high = Priority.High;
            Priority low = Priority.Low;
            Priority normal = Priority.Normal;

            Console.WriteLine($"{high} {low} {normal}");

            Console.WriteLine((int)Animal.Monkey);

            Animal animal = Animal.Sheep;
            switch (animal)
            {
                case Animal.Horse:
                    Console.WriteLine("말");
                    break;

                case Animal.Sheep:
                    Console.WriteLine("닭");
                    break;

                case Animal.Monkey:
                    Console.WriteLine("원숭이");
                    break;

                default:
                    Console.WriteLine("이외의 값");
                    break;
            }
        }
    }
}
*/

class EenumGetNames
{
    static void Main(string[] args)
    {
        Type cc = typeof(ConsoleColor);
        string[] colors = Enum.GetNames(cc);

        foreach(var color in colors)
        {
            Console.WriteLine(color);
        }
    }
}
using System;

/*
struct Point
{
    public int x;
    public int y;
}

class StructDemo
{
    static void Main()
    {
        Point point;
        point.x = 100;
        point.y = 200;
        Console.WriteLine($"x = {point.x}, y = {point.y}");
    }
}
*/

/*
namespace StructArray
{
    struct BusinessCard
    {
        public string Name;
        public int Age;
    }


    class StructArray
    {
        static void Print(string name, int age)
            => Console.WriteLine($"{name}은(는) {age}입니다.");

        static void Main()
        {
            BusinessCard biz;
            biz.Name = "권혁준";
            biz.Age = 26;
            Print(biz.Name, biz.Age);


            BusinessCard[] names = new BusinessCard[2];
            names[0].Name = "오해찬";
            names[0].Age = 27;

            names[1].Name = "김진성";
            names[1].Age = 28;

            for(int i = 0; names.Length > i; i++)
            {
                Print(names[i].Name, names[i].Age);
            }
        }
    }
}
*/

/*
class TimeSpanDemo
{
    static void Main()
    {
        TimeSpan dday = Convert.ToDateTime("2022-12-25") - DateTime.Now;
        Console.WriteLine($"{DateTime.Now.Year}년도의 크리스마스는 {(int)dday.TotalDays}일 남았습니다.");

        TimeSpan times = DateTime.Now - Convert.ToDateTime("1997-06-19");
        Console.WriteLine($"나는 지금까지 {(int)times.TotalDays}일 살았습니다.");
    }
}
*/


/*
class CharStruct
{
    static void Main()
    {
        char a = 'A';
        char b = 'a';
        char c = '1';
        char d = '\t';

        if (char.IsUpper(a))
        {
            Console.WriteLine($"{a}는 대문자");
        }

        if (char.IsLower(b))
        {
            Console.WriteLine($"{b}는 소문자");
        }

        if (char.IsNumber(c))
        {
            Console.WriteLine("{0}는 숫자형", c);
        }

        if (char.IsWhiteSpace(d))
        {
            Console.WriteLine("{0}는 공백", d);
        }


        string s = "abc";

        if (char.IsUpper(s[0]))
        {
            Console.WriteLine($"첫 글자가 대문자로 시작합니다.");
        }
        else
        {
            Console.WriteLine($"첫 글자가 소문자로 시작합니다.");
        }

        Console.WriteLine(char.MaxValue);
        Console.WriteLine(char.MinValue);
    }
}
*/

/*
class GuidDemo
{
    static void Main()
    {
        string unique = Guid.NewGuid().ToString();
        Console.WriteLine(unique);
        Console.WriteLine(Guid.NewGuid().ToString("D"));
    }
}
*/
using System;
using System.Linq;
using System.Text;

// 1.
{
    Person person = new Person
    {
        Name = "홍길동",
        Age = 25
    };

    person.Print();
}
Console.WriteLine();

// 2.
{
    Hello hello = new();
    hello.Hi();
    hello.Bye();
}
Console.WriteLine();

// 3.
{
    Calculator.Add(15, 15);
    Calculator.Subtract(30, 10);
    Calculator.Multiply(15, 2);
}
Console.WriteLine();

// 4.
{
    Console.WriteLine(StringHelper.CleanAndUpper("  hello world  "));
    Console.WriteLine(StringHelper.Reverse("hello")); // ?
    Console.WriteLine(StringHelper.IsNullOrEmpty(""));
}
Console.WriteLine();

// 5.
{
    Console.WriteLine($"제곱근: {Math.Sqrt(16)}");
    Console.WriteLine($"거듭제곱: {Math.Pow(2, 3)}");
    Console.WriteLine($"최댓값: {Math.Max(10, 20)}");
    Console.WriteLine($"최솟값: {Math.Min(10, 20)}");
}
Console.WriteLine();

// 6.
{
    StringBuilder sb = new StringBuilder();
    sb.Append("Hello");
    sb.Append(" ");
    sb.Append("World");
    Console.WriteLine(sb.ToString());

    string result = new StringBuilder()
        .Append("Hello")
        .Append(" ")
        .Append("World")
        .ToString();
    Console.WriteLine(result);
}
Console.WriteLine();

// 7.
{
    MessageBuilder mb = new MessageBuilder();

    Console.WriteLine(mb.AddText("안녕하세요!")
        .AddNewLine()
        .AddText("반갑습니다.")
        .AddSpace()
        .AddText("좋은 하루 되세요.")
        .Build());
}
Console.WriteLine();

// 8.
{
    Point p = new Point(0, 0)
        .MoveBy(10, 10)
        .MoveBy(30, 30)
        .MoveBy(60, 60);

    Console.WriteLine(p);
}
Console.WriteLine();

// 9.
{
    Console.WriteLine("  Hello World  ".Trim().ToLower().Replace(" ", "_"));
}
Console.WriteLine();

// 10.
{
    MutableCircle circle = new MutableCircle(10);
    Console.WriteLine(circle.Radius);
    circle.Radius = 20;
    Console.WriteLine(circle.Radius);
}
Console.WriteLine();

// 11.
{
    ImmutableCircle circle = new ImmutableCircle(10);
    Console.WriteLine($"원본 반지름: {circle.Radius}");
    ImmutableCircle circle2 = circle.WithRadius(20);
    Console.WriteLine($"새 원 반지름: {circle2.Radius}");
    Console.WriteLine($"원본 반지름: {circle.Radius}");
}
Console.WriteLine();

// 12.
{
    Player player = new Player("용사", 1);
    Console.WriteLine($"player1: {player.Name}, 레벨 {player.Level}");
    Player player2 = player.LevelUp();
    Console.WriteLine($"player2: {player2.Name}, 레벨 {player2.Level}");
}
Console.WriteLine();

// 13.
{
    string str = "Hello";
    string str2 = str.ToUpper();
    Console.WriteLine(str);
    Console.WriteLine(str2);
}
Console.WriteLine();

// 14.
{
    Character character = new Character("용사", 100, 1);
    character.TakeDamage(30);
    character.Heal(80);
}
Console.WriteLine();

// 15.
{
    GameHelper.CalculateDamage(5, 6);
    GameHelper.IsAlive(10);
    GameHelper.GetHealthStatus(1, 10);
}
Console.WriteLine();

// 16.
{
    Vector2D vector = new Vector2D(1, 1);
    vector.Add(2, 3).Multiply(2).Add(-1, -2).ToString();
}
Console.WriteLine();

// 16.
class Vector2D
{
    public readonly double X, Y;

    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public Vector2D Add(double x, double y)
    {
        return new Vector2D(X + x, Y + y);
    }

    public Vector2D Multiply(double scalar)
    {
        return new Vector2D(X * scalar, Y * scalar);
    }

    public void ToString()
    {
        Console.WriteLine($"({X}, {Y})");
    }
}

// 15.
static public class GameHelper
{
    static public void CalculateDamage(int baseDamage, int level)
    {
        Console.WriteLine($"계산된 데미지: {baseDamage + level * 5}");
    }

    static public void IsAlive(int health)
    {
        Console.WriteLine($"생존 여부: {health > 0}");
    }

    static public void GetHealthStatus(int health, int maxHealth)
    {
        double gijun = (double) health / maxHealth;

        if (gijun > 0.75) Console.WriteLine($"체력 상태: 양호");

        else if (gijun > 0.4) Console.WriteLine($"체력 상태: 주의");

        else if (gijun > 0) Console.WriteLine($"체력 상태: 위험");

        else Console.WriteLine($"체력 상태: 사망");
    }
}

// 14.
partial class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }

    public Character(string name, int health, int level)
    {
        Name = name;
        Health = health;
        Level = level;
        Console.WriteLine($"{Name} - 레벨: {Level}, 체력: {health}");
    }
}

partial class Character
{
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name}(이)가 {damage}의 피해를 입음. 남은 체력: {Health}");
    }

    public void Heal(int amount)
    {
        Health += amount;
        Console.WriteLine($"{Name}(이)가 {amount}만큼 회복함. 현재 체력: {Health}");
    }
}

// 12.
class Player
{
    public readonly string Name;
    public readonly int Level;

    public Player(string name, int level)
    {
        Name = name;
        Level = level;
    }

    public Player LevelUp()
    {
        return new Player(Name, Level + 1);
    }
}

// 11.
class ImmutableCircle
{
    public int Radius { get; }

    public ImmutableCircle(int radius) => Radius = radius;

    public ImmutableCircle WithRadius(int newRadius)
    {
        return new ImmutableCircle(newRadius);
    }
}

// 10.
class MutableCircle
{
    public int Radius {  get; set; }

    public MutableCircle(int radius) => Radius = radius;
}

// 8.
class Point
{
    private readonly int X;
    private readonly int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point MoveBy(int x, int y)
    {
        return new Point(x, y);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

// 7.
class MessageBuilder
{
    private string _message = "";

    public MessageBuilder AddText(string text)
    { 
        _message += text;
        return this;
    }

    public MessageBuilder AddSpace()
    {
        _message += " ";
        return this;
    }

    public MessageBuilder AddNewLine()
    {
        _message += "\n";
        return this;
    }

    public string Build()
    {
        return _message;
    }
}

// 4.
static class StringHelper
{
    static public string CleanAndUpper(string input) => input.Trim().ToUpper();

    static public string Reverse(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string newString = new string(charArray);
        return newString;
    }

    static public bool IsNullOrEmpty(string input) => string.IsNullOrEmpty(input);
}

// 3.
static class Calculator
{
    static public void Add(int a, int b) => Console.WriteLine($"덧셈: {a + b}");

    static public void Subtract(int a, int b) => Console.WriteLine($"뺄셈: {a - b}");

    static public void Multiply(int a, int b) => Console.WriteLine($"곱셈: {a * b}");
}

// 2.
partial class Hello
{
    public void Hi()
    {
        Console.WriteLine("안녕하세요!");
    }
}

partial class Hello
{
    public void Bye()
    {
        Console.WriteLine("안녕히 가세요!");
    }
}

// 1.
partial class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

partial class Person
{
    public void Print()
    {
        Console.WriteLine($"{Name}: {Age}");
    }
}
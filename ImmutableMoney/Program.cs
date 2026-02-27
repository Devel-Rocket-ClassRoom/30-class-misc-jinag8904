using System;

Money money = new Money(100, 50); 

Console.WriteLine("=== 초기 화폐 ===");
Console.WriteLine($"지갑: " + money);

Console.WriteLine("\n=== 화폐 추가 ===");
Money money2 = money.Add(50, 30);

Console.WriteLine($"추가 후: " + money2);
Console.WriteLine($"원본 지갑: " + money);

Console.WriteLine("\n=== 화폐 차감 ===");
Money money3 = money2.Subtract(70, 60);

Console.WriteLine($"차감 후: " + money3);
Console.WriteLine($"원본 지갑: " + money);

Console.WriteLine("\n=== 메서드 체이닝 ===");
Money money4 = money.Add(50, 30)
    .Subtract(70, 60)
    .Add(40, 10);
Console.WriteLine($"결과: " + money4);
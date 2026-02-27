using System;

Console.WriteLine("=== 기본 쿼리 ===");
QueryBuilder qb = new("");
qb.Select("*").From("Users").Build();

Console.WriteLine("\n=== 조건 쿼리 ===");
QueryBuilder qb2 = new("");
qb2.Select("Name, Age").From("Users").Where("Age > 18").Build();

Console.WriteLine("\n=== 정렬 쿼리 ===");
QueryBuilder qb3 = new("");
qb3.Select("*").From("Products").Where("Price > 1000").OrderBy("Price").Build();
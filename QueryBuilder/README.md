# 메서드 체이닝 쿼리 빌더

SQL과 유사한 쿼리 문자열을 생성하는 `QueryBuilder` 클래스를 
메서드 체이닝 방식으로 구현하세요.

`QueryBuilder` 클래스는 다음 메서드를 포함합니다:

- `Select(string columns)`: SELECT 절 추가 (자기 자신 반환)
- `From(string table)`: FROM 절 추가 (자기 자신 반환)
- `Where(string condition)`: WHERE 절 추가 (자기 자신 반환)
- `OrderBy(string column)`: ORDER BY 절 추가 (자기 자신 반환)
- `Build()`: 최종 쿼리 문자열 반환

## 예상 실행 결과

```
=== 기본 쿼리 ===
SELECT * FROM Users

=== 조건 쿼리 ===
SELECT Name, Age FROM Users WHERE Age > 18

=== 정렬 쿼리 ===
SELECT * FROM Products WHERE Price > 1000 ORDER BY Price
```

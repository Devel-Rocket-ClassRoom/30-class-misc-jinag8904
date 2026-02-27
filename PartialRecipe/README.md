# 부분 클래스로 레시피 카드 만들기

요리 레시피를 관리하는 클래스를 부분 클래스로 구현하세요.

레시피는 다음 기능을 가집니다:

**정보 부분 (첫 번째 partial class - `Recipe.Info.cs`)**

- 이름(Name): 읽기 전용 속성
- 인분(Servings): 읽기 전용 속성
- 재료 배열과 재료 개수를 저장하는 필드
- 생성자: 이름, 인분, 최대 재료 수를 매개변수로 받음

**조리 부분 (두 번째 partial class - `Recipe.Cooking.cs`)**

- `AddIngredient(string ingredient)`: 재료를 추가함 (배열이 가득 차면 메시지 출력)
- `PrintRecipe()`: 레시피 이름, 인분, 재료 목록을 출력함
- `HasIngredient(string ingredient)`: 특정 재료가 포함되어 있는지 확인함

## 예상 실행 결과

```
=== 비빔밥 (2인분) ===
재료:
  1. 밥
  2. 고추장
  3. 계란
  4. 시금치
  5. 당근

계란 포함: True
소고기 포함: False

=== 샌드위치 (1인분) ===
재료:
  1. 빵
  2. 햄
  3. 치즈
```

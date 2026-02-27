# 정적 유틸리티 클래스

게임에서 자주 사용하는 유틸리티 기능을 제공하는 정적 클래스 `GameUtils`를 구현하세요.

`GameUtils` 클래스는 다음 정적 메서드를 포함합니다:

- `Clamp(int value, int min, int max)`: 값을 최솟값과 최댓값 사이로 제한하여 반환함
  - value가 min보다 작으면 min 반환
  - value가 max보다 크면 max 반환
  - 그 외에는 value 그대로 반환
- `GetPercentage(int current, int max)`: 현재 값을 최대값 대비 백분율로 반환함
- `IsInRange(int value, int min, int max)`: 값이 범위 내에 있는지 확인함

## 예상 실행 결과

```
=== Clamp 테스트 ===
Clamp(-10, 0, 100) = 0
Clamp(50, 0, 100) = 50
Clamp(150, 0, 100) = 100

=== GetPercentage 테스트 ===
GetPercentage(75, 100) = 75%
GetPercentage(30, 200) = 15%

=== IsInRange 테스트 ===
IsInRange(50, 0, 100) = True
IsInRange(-5, 0, 100) = False
IsInRange(150, 0, 100) = False
```

# RegressionLab (Buggy)

Этот вариант содержит **намеренно внесённые дефекты** в реализацию (src/RegressionLab).
Тесты в `tests/RegressionLab.Tests` описывают корректное поведение и **будут падать**, пока студенты не исправят код.

## Как работать студенту
1. Открой `RegressionLab_Buggy.sln` в Visual Studio 2022+ (.NET 8 SDK).
2. Запусти все тесты в Test Explorer — зафиксируй красные тесты.
3. По очереди исправляй методы в `src/RegressionLab` до зелёного состояния.
4. Оставь регрессионные тесты, не меняй их ожидания.

## Где дефекты
- `PriceCalculator.CalculateFinal`: скидка после НДС, ToEven, нет валидации.
- `DateUtils.OverlapMinutes`: нет нормализации, возвращает отрицательные значения, округляет вверх.
- `StringNormalizer.NormalizeProductCode`: сохраняет символы/нижний регистр, не фильтрует токены.
- `TaxCalculator.ComputeAnnualTax`: плоская ставка 15%, нет потолка.
- `LoyaltyPoints`: LIFO-списание, нет сгорания, баланс считает всё подряд.

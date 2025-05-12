# MonopolyTestTask
Тестовое задание на вакансию Junior C# developer в Монополия
## Описание программы
Программа написана на C# с использованием WindowsForms.

[Релиз-версия к запуску](https://github.com/punkmyduck/MonopolyTestTask/releases/tag/TestTask)

[Путь в папку с исходным кодом программы](MonopolyWarehouse/).

### Объекты склада
Основные классы, описанные в программе:
- WarehouseItem.cs - абстрактный класс, описывающий поведение объекта склада;
- Box.cs - коробка, наследник класса WarehouseItem;
- Pallet.cs - паллета, наследник класса WarehouseItem, содержит изменяемый список коробок.

Файлы классов, описанных сверху, [находятся тут](MonopolyWarehouse/WarehouseObjects).

### Поставщик данных
Для загрузки данных предусмотрен интерфейс IDataProvider, предоставляющих два метода:
- List<Pallet> GetPallets();
- List<Box> GetBoxes();

В данном проекте только один класс реализует интерфейс - DataRandomGenerator. 
Данный класс заполняет данные случайным образом.

Файлы классов, описанных сверху, [находятся тут](MonopolyWarehouse/WarehouseData).

### WarehouseService
Данный класс агрегирует поставщик данных, объекты склада и несколько методов для работы с данными.
Все методы описаны в файле класса, [который находится тут](MonopolyWarehouse/WarehouseService.cs).

### Юнит-тесты
Юнит-тесты основных классов программы [находятся тут](UnitTestApp.Tests).

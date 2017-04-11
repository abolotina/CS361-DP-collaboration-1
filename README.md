# Документация

## Система оплаты и скидочных карт

Проект разделён архитектурно на две части: функциональное ядро (реализовано в виде DLL), содержащее классы базовых сущностей (магазин, покупатель, скидочная карта, ...) и паттерны, и отделённый от него интерфейс WPF.

## Порождающие паттерны

### «Абстрактная фабрика»

Паттерн реализован для классов магазина, покупателя, системы скидочных карт и системы команд.

#### UML-диаграмма:

![UMl Diagram](https://github.com/Maryann13/CS361-DP-collaboration-1/blob/master/uml-abstract-factory.png)

### «Строитель»

Паттерн реализован для класса магазина.

#### UML-диаграмма:

![UMl Diagram](https://github.com/Maryann13/CS361-DP-collaboration-1/blob/master/uml-builder.png)

### «Одиночка»

Паттерн реализован для классов покупателя и корзины.

#### UML-диаграмма:

![UMl Diagram](https://github.com/Maryann13/CS361-DP-collaboration-1/blob/master/uml-singleton.png)

## Разработчики

**Анна Болотина:**
* Продумала архитектуру проекта, базовые классы и связи между ними, порождающие паттерны.
* Построила иерархию базовых классов.
* Построила паттерны «Абстрактная фабрика» для классов магазина, покупателя, системы скидочных карт и системы команд.
* Реализовала паттерн «Строитель» для класса магазина.
* Реализовала паттерны «Одиночка» для классов покупателя и корзины.

**Антонио Максимович:**
* Продумал интерактивный графический интерфейс.
* Построил графический интерфейс WPF.
* Реализовал парсинг входных файлов.
* Реализовал функциональность интерфейса.
* Реализовал загрузку модульных тестов в демонстрационном режиме.

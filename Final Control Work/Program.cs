﻿using ClassLibrary;

// #1 
//Объявить двумерный массив для элементов типа int. Инициализировать его вручную
//или random. Присвоить значение 1 всем элементам массива, которые лежат выше
//главной диагонали.

int[,] array = new int[3, 3]
{
    { 2, 3, 4 },
    { 5, 6, 7 },
    { 8, 9, 10 }
};

var handledArray = ArrayHandler.HandleArray(array);

// #2 
//Разработайте метод расширения для типа int, возвращающий значение в виде строки.
//Пример: Возвращает «1234» в виде «один два три четыре».

string words = 1234567890.NumbersToWords();

// #3 
//Объявить коллекцию элементов типа int. Инициализировать его вручную или random.
//При помощи LINQ отсортировать коллекцию по возрастанию и вернуть вторую
//половину коллекции (округляя вверх если число элементов нечётное)
//остортированную по убыванию, где каждый элемент будет возведён в квадрат.

// ps: думаю если 2 разных метода то должна возвращаться новая коллекция, ну иммутабельность там итд

List<int> intList = new() { 23, 546, 123, -12, 87, 12, -9, 17, 59, 34, 78, 19, -93, 27, 0 };

var sortedSecondHalfCollection = IntCollectionHandler.SortAndReturnHalf(intList);
var descSortedAndSquared = IntCollectionHandler.SortDescAndSquare(intList);

// #4 
//Разработайте класс содержащий произвольный публичный метод и событие. После 10
//вызовов метода у любых экземпляров разработанного класса необходимо вызвать
//событие и информировать об этом пользователя. Обработку события произвести либо
//при помощи анонимного метода, либо при помощи лямбда-вырожения.

var eventClass = new EventClass();

for (int i = 0; i < 10; i++)
{
    eventClass.AddConsumer(() => Console.WriteLine($"Consumer invoked"));
    eventClass.Increment();
}

// #5
//Разработайте класс для выполнения математических функций (факториал, возведение
//в степень). Необходимо предусмотреть защиту от некорректного ввода данных, а
//также обработку исключетельных ситуаций. При возникновении исключительной
//ситуации пользователь должен получить соответствующее сообщение с описанием
//исключительной ситуации. Не забывайте про принципы ООП.

var factorial = MathOperations.Factorial(12);
var exponentiate = MathOperations.Exponentiate(2, 8);
static class MathOperations
{
    public static int? Factorial(int number)
    {
        try
        {
            return MathHandler.Factorial(number);
        } catch (Exception ex)
        {
            ExceptionHandler(ex);
            return null;
        }
    }

    public static int? Exponentiate(int number, int power)
    {
        try
        {
            return MathHandler.Exponentiate(number, power);
        } catch (Exception ex)
        {
            ExceptionHandler(ex);
            return null;
        }
    }

    static void ExceptionHandler(Exception ex)
    {
        Console.WriteLine($"Something went wrong! {ex.Message}");
    }
}

// #6 
//Используя обобщения разработайте несколько интерфейсов, первый - для
//сохрания/чтения последовательности объектов произвольного типа в/из источник
//данных, второй - для CRUD операций (взаимодействие с последоватеьностью
//объектов в памяти). Разработайте несколько классов, реализующих интерфейсы,
//разработанные ранее. Вид последовательности элементов и файл для хранения
//выберите самостоятельно при создании реализации интерфейса. Не забывайте про
//принципы ООП.

// ps: имхо слишком "толстое" задание :D благо что последнее
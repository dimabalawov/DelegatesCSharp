using System;

public class DateAndGeometry
{
    public static void ShowCurrentTime() =>
        Console.WriteLine("Текущее время: " + DateTime.Now.ToShortTimeString());

    public static void ShowCurrentDate() =>
        Console.WriteLine("Текущая дата: " + DateTime.Now.ToShortDateString());

    public static void ShowCurrentDayOfWeek() =>
        Console.WriteLine("Текущий день недели: " + DateTime.Now.DayOfWeek);

    public static double CalculateTriangleArea(double baseLength, double height) =>
        0.5 * baseLength * height;

    public static double CalculateRectangleArea(double width, double height) =>
        width * height;
}

public class Program
{
    public static void Main()
    {
        Action showTime = DateAndGeometry.ShowCurrentTime;
        Action showDate = DateAndGeometry.ShowCurrentDate;
        Action showDayOfWeek = DateAndGeometry.ShowCurrentDayOfWeek;

        showTime();
        showDate();
        showDayOfWeek();

        Func<double, double, double> triangleArea = DateAndGeometry.CalculateTriangleArea;
        Func<double, double, double> rectangleArea = DateAndGeometry.CalculateRectangleArea;

        Console.WriteLine("Площадь треугольника: " + triangleArea(5, 10));
        Console.WriteLine("Площадь прямоугольника: " + rectangleArea(5, 10));
    }
}

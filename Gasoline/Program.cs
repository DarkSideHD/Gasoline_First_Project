using System.ComponentModel.DataAnnotations;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите стоимость бензина: ");
        double price = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите расстояние: ");
        double distance = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите среднюю скорость: ");
        double time = double.Parse(Console.ReadLine());

        Car duster = new Car();
        duster.Name = "Duster";
        duster.Consumption = 10;

        Car dusterWinter = new Car();
        dusterWinter.Name = "Duster";
        dusterWinter.Consumption = 13;

        Car tahoe = new Car();
        tahoe.Name = "Tahoe";
        tahoe.Consumption = 15;

        Car tahoeWinter = new Car();
        tahoeWinter.Name = "Tahoe";
        tahoeWinter.Consumption = 17;

        var dusterResult = TripCalc(duster, price, distance);
        var dusterWinterResult = TripCalc(dusterWinter, price, distance);
        var tahoeResult = TripCalc(tahoe, price, distance);
        var tahoeWinterResult = TripCalc(tahoeWinter, price, distance);
        var timeResult = TimeCalc(time, distance);

        Console.WriteLine($"Стоимость поездки на Duster летом:{dusterResult}");
        Console.WriteLine($"Стоимость поездки на Duster зимой:{dusterWinterResult}");
        Console.WriteLine($"Стоимость поездки на Tahoe летом: {tahoeResult}");
        Console.WriteLine($"Стоимость поездки на Tahoe зимой: {tahoeWinterResult}");
        Console.WriteLine($"Среднее затраченное время на дорогу: {timeResult} часов");
    }

    static double TripCalc(Car car, double price, double distance)
    {
        return price / 100 * car.Consumption * distance;
    }

    static double TimeCalc(double distance, double time)
    {
        return time / distance;
    }
}

public class Car
{
    public string Name { get; set; }
    public double Consumption { get; set; }
}

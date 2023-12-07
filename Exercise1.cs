using System;

public class Car
{
	private string brand;
	private int year;
	private float price;

	public Car(string brand, int year, float price)
	{
		this.brand = brand;
		this.year = year;
		this.price = price;
	}

	public void DisplayDetails()
	{
		Console.WriteLine($"Brand: {brand}, Year: {year}, Price: {price}");
	}
}

class Program
{
	static void Main()
	{
		Car myCar = new Car("Toyota", 2020, 30000.50f);
		myCar.DisplayDetails();
	}
}

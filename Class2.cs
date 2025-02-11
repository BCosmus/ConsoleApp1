using System;

class Vehicle
{
    public string Make { get; private set; }
    public string Model { get; private set; }
    public string EngineNumber { get; private set; }
    public decimal SalePrice { get; private set; }

    // Method to set vehicle details
    public void SetVehicle(string make, string model, string engineNumber, decimal salePrice)
    {
        Make = make;
        Model = model;
        EngineNumber = engineNumber;
        SalePrice = salePrice;
    }

    // Method to calculate profit
    public decimal GetProfit()
    {
        return SalePrice * 0.15m;
    }

    // Method to display vehicle details
    public void DisplayVehicle()
    {
        Console.WriteLine($"Make: {Make}, Model: {Model}, Engine Number: {EngineNumber}, Sale Price: {SalePrice:C}, Profit: {GetProfit():C}");
    }
}

class Program
{
    static void Main()
    {
        Vehicle car = new Vehicle();
        car.SetVehicle("Nissan", "Sunny", "ENG12345", 15000);
        car.DisplayVehicle();
    }
}

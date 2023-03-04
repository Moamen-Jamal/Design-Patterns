namespace AbstractFactory.After.TruckProduct
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class Truck1 : ITruck
    {
        public string truckName { get; set; }
        public int modelNumber { get; set; }
        public Truck1()
        {
            truckName = "Truck1";
            modelNumber = 2020;
        }

        
    }
}

namespace AbstractFactory.After.TruckProduct
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class Truck2 : ITruck
    {
        public string truckName { get; set; }
        public int modelNumber { get; set; }
        public Truck2()
        {
            truckName = "Truck1";
            modelNumber = 2020;
        }


    }
}

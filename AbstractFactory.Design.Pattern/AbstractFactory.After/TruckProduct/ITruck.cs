namespace AbstractFactory.After.TruckProduct
{
    interface ITruck
    {
        string truckName { get; set; }
        int modelNumber { get; set; }

        void RunTruck()
        {
            Console.WriteLine(truckName + " is running.");
        }

        void RepairTruck()
        {
            Console.WriteLine(truckName + " with model no " + modelNumber + " is being repaired");
        }
    }
}

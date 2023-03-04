namespace FactoryMethod.Interface.Factory
{
    /// <summary>
    /// The 'Product' interface
    /// </summary>
    interface ICar
    {
        string carName { get; set; }
        int modelNumber { get; set; }

        void RunCar()
        {
            Console.WriteLine(carName + " is running.");
        }

        void RepairCar()
        {
            Console.WriteLine(carName + " with model no " + modelNumber + " is being repaired");
        }

    }
}

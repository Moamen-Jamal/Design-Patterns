namespace FactoryMethod.Before.Start
{
    abstract class Car
    {
        public string carName { get; set; }
        public int modelNumber { get; set; }

        public void RunCar()
        {
            Console.WriteLine(carName + " is running.");
        }

        public void RepairCar()
        {
            Console.WriteLine(carName + " with model no " + modelNumber + " is being repaired");
        }

    }
}

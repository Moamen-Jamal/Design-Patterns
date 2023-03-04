namespace FactoryMethod.Interface.Factory
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class SedanCar : ICar
    {
        public string carName { get; set; }
        public int modelNumber { get; set; }
        public SedanCar()
        {
            carName = "BMW";
            modelNumber = 2020;
        }

        
    }
}

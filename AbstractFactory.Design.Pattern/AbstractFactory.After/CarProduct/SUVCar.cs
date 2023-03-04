namespace AbstractFactory.After.CarProduct
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class SUVCar : ICar
    {
        public string carName { get; set; }
        public int modelNumber { get; set; }
        public SUVCar()
        {
            carName = "Mercidez";
            modelNumber = 2021;
        }
    }
}

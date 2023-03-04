namespace FactoryMethod.Interface.Factory
{
    /// <summary>
    /// A 'ConcreteFactory' class
    /// </summary>
    class CarFactory : ICarFactory
    {
        public ICar GetCarType(string? carType)
        {
            switch (carType)
            {
                case "S":
                    return new SedanCar();   
                case "U":
                    return new SUVCar();
                default:
                    return new SedanCar();
            }
        }
    }
}

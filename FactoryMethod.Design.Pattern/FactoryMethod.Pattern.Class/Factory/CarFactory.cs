namespace FactoryMethod.Pattern.Class.Factory
{
    class CarFactory
    {
        public Car GetCarType(string? carType)
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

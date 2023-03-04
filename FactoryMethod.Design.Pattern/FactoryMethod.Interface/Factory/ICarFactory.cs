namespace FactoryMethod.Interface.Factory
{
    /// <summary>
    /// A 'ConcreteFactory' interface
    /// </summary>
    interface ICarFactory
    {
        ICar GetCarType(string? carType);
    }
}

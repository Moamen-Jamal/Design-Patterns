namespace Strategy.After
{
    /// <summary>
    /// The 'Context' class
    /// The context maintains a reference to one of the strategy
    /// objects. The context doesn't know the concrete class of a
    /// strategy. It should work with all strategies via the strategy interface or abstract class.
    /// </summary>
    public class Mechanic
    {
        private Algorithm? Algorithm;
        public void SetAlgorithm(Algorithm algorithm)
        {
            Algorithm = algorithm;
        }
        public void DisassembleCar()
        {
            Algorithm.PerformAlgorithm();
        }
    }
}

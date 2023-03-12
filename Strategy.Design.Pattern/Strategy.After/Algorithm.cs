namespace Strategy.After
{
    /// <summary>
    /// The 'strategy' abstrct class
    /// The strategy abstrct class or interface declares operations common to all
    /// supported versions of some algorithm. The context uses this
    /// interface to call the algorithm defined by the concrete strategies.
    /// </summary>
    public abstract class Algorithm
    {
        public abstract void PerformAlgorithm();
    }
}

namespace Strategy.After
{
    /// <summary>
    /// The 'ConcreteStrategy' class
    /// implements the algorithm using the Strategy abstract class.
    /// </summary>
    public class Opel : Algorithm
    {
        public override void PerformAlgorithm()
        {
            Console.WriteLine("Performing Opel Disassembly Algorithm");
        }
    }
}

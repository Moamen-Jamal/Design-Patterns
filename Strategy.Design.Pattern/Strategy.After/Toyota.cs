namespace Strategy.After
{
    /// <summary>
    /// The 'ConcreteStrategy' class
    /// implements the algorithm using the Strategy abstract class.
    /// </summary>
    public class Toyota : Algorithm
    {
        public override void PerformAlgorithm()
        {
            Console.WriteLine("Performing Toyota Disassembly Algorithm");
        }
    }
}

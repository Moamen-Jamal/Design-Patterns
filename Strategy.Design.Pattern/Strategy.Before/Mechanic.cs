namespace Strategy.Before
{
    public class Mechanic
    {
        private string? carType;
        public Mechanic(string carType)
        {
            this.carType = carType;
        }
        public void DisassembleCar()
        {
            if(carType == "Toyota")
            {
                Console.WriteLine("Performing Toyota Disassembly Algorithm");
            }
            else if (carType == "Cheverlet")
            {
                Console.WriteLine("Performing Cheverlet Disassembly Algorithm");
            }
            else if (carType == "KIA")
            {
                Console.WriteLine("Performing KIA Disassembly Algorithm");
            }
            else if (carType == "Opel")
            {
                Console.WriteLine("Performing Opel Disassembly Algorithm");
            }
        }
    }
}

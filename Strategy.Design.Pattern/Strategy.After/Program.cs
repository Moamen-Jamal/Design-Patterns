using Strategy.After;

var jamalMechanic = new Mechanic();
jamalMechanic.SetAlgorithm(new KIA());
jamalMechanic.DisassembleCar();

jamalMechanic.SetAlgorithm(new Toyota());
jamalMechanic.DisassembleCar();

Console.Read();
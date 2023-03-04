using Singleton.Pattern.Before.Start;

MemoryLogger logger;

void AssignVoucher(string email, string voucher)
{
    logger = new MemoryLogger();

    //Logic here
    logger.LogInfo($"Voucher '{voucher}' assigned");

    //another logic
    logger.LogError($"unable to sent email to {email}");
}

void UseVoucher(string voucher)
{
    logger = new MemoryLogger();

    //Logic here
    logger.LogInfo($"{voucher} is used");

    //another logic
    logger.LogWarning($"3 attempts made to validate the voucher");
}

AssignVoucher("momenGamal@gmail.com", "ABC12345");
UseVoucher("ABC12345");

logger.ShowLog();
Console.ReadLine();

//Pros of Singleton Design Pattern
// 1- Single Instance
// 2- Global Access
// 3- One Time Initialization

//Cons of Singleton Design Pattern
// 1- Violate SRP
// 2- Tight Coulping
// 3- Hard to Unit Test

//In this example MemoryLogger is the singleton

//Singleton Real World Usages Examples
// 1- Logging
// 2- Managing Connection to Database
// 3- File
// 4- Configuration
// 5- Cache



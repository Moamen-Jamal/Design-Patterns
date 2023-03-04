
using Singleton.Start.Start;

MemoryLogger logger;

void AssignVoucher(string email, string voucher)
{
    logger = MemoryLogger.getLoger;

    //Logic here
    logger.LogInfo($"Voucher '{voucher}' assigned");

    //another logic
    logger.LogError($"unable to sent email to {email}");
}

void UseVoucher(string voucher)
{
    logger = MemoryLogger.getLoger;

    //Logic here
    logger.LogInfo($"{voucher} is used");

    //another logic
    logger.LogWarning($"3 attempts made to validate the voucher");
}

AssignVoucher("momenGamal@gmail.com", "ABC12345");
UseVoucher("ABC12345");

logger.ShowLog();
Console.ReadLine();

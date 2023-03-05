namespace Chain.of.Responsibility.Design.Pattern
{
    /// <summary>
    /// The 'Client' class (Optional)
    /// to handle the start of the request and build the chain og handlers
    /// </summary>
    class Client
    {
        public static void ClientCode(AbstractHandler handler)
        {
            List<Customer> customers = new List<Customer>{
                new Customer{ Id = 1, Email = "momen95gamal@gmail.com",UserName = "momengamal",PhoneNumber = "123432144522"},
                new Customer{ Id = 2, Email = "Ahmed95Ali@gmail.com",UserName = "",PhoneNumber = "123432144522"},
                new Customer{ Id = 3, Email = "",UserName = "Fathy",PhoneNumber = "123432144522"},
                new Customer{ Id = 4, Email = "Mohamed@gmail.com",UserName = "Mohamed",PhoneNumber = ""},
                new Customer{ Id = 5, Email = "",UserName = "",PhoneNumber = ""}
            };
            foreach (var customer in customers)
            {
                Console.WriteLine($"Client: Is the Customer Authorized?");

                var result = handler.HandleAuthorization(customer);

                if (result != null)
                {
                    Console.Write($"   {result}");
                    Console.WriteLine("----------------");
                }
                else
                {
                    Console.WriteLine($"   Customer is not Authorized.");
                }
            }
        }
    }
}

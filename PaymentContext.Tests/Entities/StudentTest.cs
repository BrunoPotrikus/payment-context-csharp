using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void StudentTest1()
        {
            var name = new Name("Teste", "teste");
            foreach(var not in name.Notifications)
            {
                Console.WriteLine(not.Message);
            }
        }
    }
}

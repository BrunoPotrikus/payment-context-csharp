using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void StudentTest1()
        {
            var subscription = new Subscription();
            var student = new Student("Bruno", "Potrikus", "1234567890", "bruno@email.com");
            student.AddSubscription(subscription);
        }
    }
}

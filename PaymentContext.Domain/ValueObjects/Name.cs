using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;


namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsEmpty(FirstName, "FirstName", "O nome não pode ser vazio")
                .IsEmpty(LastName, "LastName", "O sobrenome não pode ser vazio")
                .IsNull(FirstName, "FirstName", "O nome não pode ser nulo")
                .IsNull(LastName, "LastName", "O sobrenome não pode ser nulo")
                .IsLowerThan(FirstName, 3, "FirstName", "O nome deve ter pelo menos 3 caracteres")
                .IsLowerThan(LastName, 3, "LastName", "O sobrenome deve ter pelo menos 3 caracteres")
                .IsGreaterThan(FirstName, 80, "FirstName", "O nome deve ter no máximo 80 caracteres")
                .IsGreaterThan(LastName, 80, "LastName", "O sobrenome deve ter no máximo 80 caracteres")
            );
                
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}

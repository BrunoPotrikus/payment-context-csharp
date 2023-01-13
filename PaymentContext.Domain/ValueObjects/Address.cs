using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string country, string state, string city, string street, string neighborhood, string zipCode)
        {
            Country = country;
            State = state;
            City = city;
            Neighborhood = neighborhood;
            Street = street;
            ZipCode = zipCode;

            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsLowerThan(Street, 3, "Street", "A rua deve ter pelo menos 3 caracteres")
            );
        }

        public string Country { get; private set; }
        public string State { get; private set; }
        public string City { get; private set; }
        public string Neighborhood { get; private set; }
        public string Street { get; private set; }
        public string ZipCode { get; private set; }
    }
}

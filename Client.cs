using System;

namespace MarketPlace
{
    public class Client : User
    {
        public Client(string name, string user, string password, DateTime birthDate, string cpf, Address deliveryAddress, Address billingAddress) : base(name, user, password, birthDate)
        {
            this.cpf = cpf;
            this.deliveryAddress = deliveryAddress;
            this.billingAddress = billingAddress;
        }

        public Address deliveryAddress { get; set; }
        public Address billingAddress { get; set; }
        public string cpf { get; private set; }
    }
}
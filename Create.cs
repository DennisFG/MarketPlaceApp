using System;

namespace MarketPlace
{
    public class Create
    {
        public string createMenu()
        {
            Console.WriteLine("Observe o menu e escolha o número da opção desejada");
            Console.WriteLine("01 - Cadastrar Novo Usuário");
            Console.WriteLine("02 - Cadastrar Novo Vendedor");
            Console.WriteLine("03 - Cadastrar Novo Cliente");
            Console.Write("Opção: ");
            return Console.ReadLine();
        }
        public static void createUser(string name, string user, string password, DateTime birthDate)
        {
            User _user = new User(name, user, password, birthDate);
        }
        public static void createClient(string name, string user, string password, DateTime birthDate, string cpf, Address deliveryAddress, Address billingAddress)
        {
            Client _client = new Client(name, user, password, birthDate, cpf, deliveryAddress, billingAddress);
        }

        public static void createSeller(string name, string user, string password, DateTime birthDate, string cnpj)
        {
            Seller _seller = new Seller(name, user, password, birthDate, cnpj);
        }
    }
}
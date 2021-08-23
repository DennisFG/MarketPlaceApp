using System;
using System.Collections.Generic;


namespace MarketPlace
{
    public class Seller : User
    {
        public Seller(string name, string user, string password, DateTime birthDate, string cnpj) : base(name, user, password, birthDate)
        {
            this.cnpj = cnpj;
            var catalogos = new List<Catalogo>();

        }

        public string cnpj { get; private set; }

        // criar catálogo


        public static void novoCatalogo(string nomeCatalogo)
        {
            
            Catalogo catalogo = new Catalogo();
            catalogo = nomeCatalogo;

            this.catalogos.add()
        }

        // cadastrar produtos

        // deletar produtos

    }
}
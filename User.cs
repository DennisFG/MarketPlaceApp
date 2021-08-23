using System;

namespace MarketPlace
{
    public class User
    {
        public User(string name, string user, string password, DateTime birthDate)
        {
            this.id = newId();
            this.user = user;
            this.password = password;
            this.birthDate = birthDate;
        }

        private int newId()
        {
            throw new NotImplementedException();
        }

        public int id { get; set; }

        public string name { get; set; }

       

        public string user { get; set; }

        public string password { get; set; }

        public DateTime birthDate { get; set; }
    }
}
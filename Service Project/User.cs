using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Project
{
    class User
    {
        public Guid _id;
        public string _userName;
        public string _password;
        public User()
        {
            this._id = Guid.NewGuid();
        }
        public User(string name, string password) : this()
        {
            this._userName = name;
            this._password = Crypto.Encrypt(password);
        }
        //TODO encrypt - decrypt
        public void DisplayUserInfo()
        {
            Console.WriteLine($"User name - {this._userName}, user password - {this._password}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User("Vlad", "Belmas");
            var user2 = new User("Test", "Test256");
            var repo = new UserRepository();

            repo.Insert(user1);
            repo.Insert(user2);

            repo.GetById(user2._id);
            repo.DisplayUserInfo(user2._id);
           // repo.Update(user2._id, user1);
            repo.DisplayUserInfo(user2._id);

            //repo.Delete(user2._id);
            

            var users = repo.All();
            foreach (var user in users)
            {
                user.DisplayUserInfo();
            }

            Console.WriteLine($"password decrypt: \'{Crypto.Decrypt(user1._password)}\'");
            Console.ReadKey();
        }
    }
}

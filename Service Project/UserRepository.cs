using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Project
{
    class UserRepository
    {
        private static Dictionary<Guid, User> _users = new Dictionary<Guid, User>();
        public User[] All()
        {
            return _users.Values.ToArray();
        }
        //TODO GetById
        public void GetById(Guid _id)
        {
            Console.WriteLine($"this user {_users[_id]._userName} and password {_users[_id]._password}");
        }
        public void Insert(User user)
        {
            _users.Add(user._id, user);
        }
        //TODO Update
        public bool Update(Guid _id, User user)
        {
            _users[_id] = user;
            return true;
        }
        public void Delete(Guid id)
        {
            if (_users.ContainsKey(id)) // Returns true.
            {
                _users.Remove(id); // This is the value at cat.
            }
        }
        public void DisplayUserInfo(Guid _id)
        {
            Console.WriteLine($"Username - {_users[_id]._userName} and password - {_users[_id]._password}");
        }
    }
}

using HW4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW4.Repository
{
    public class UserRepository : IUserRepository
    {
        public List<User> users;
        public UserRepository()
        {
            users= new List<User>();

        }

        public void Create(string name,string phone,DateTime birthdate)
        {
            User user = new User();
            user.Name = name;
            user.Phone = phone;
            user.Birthdate = birthdate;
            user.CreateDate=DateTime.Now;
            users.Add(user);
        }

        public void Delete(string name)
        {
            var user = SelectUserByName(name);
            users.Remove(user);
        }

        public List<User> GetAll()
        {
            return users;
        }

        public void Update(string name,string phone,DateTime birthDate)
        {
            var user = SelectUserByName(name);
            Delete(name);
            user.Phone=phone;
            user.Birthdate=birthDate;
            user.CreateDate= DateTime.Now;
            users.Add(user);

        }


        public User SelectUserByName(string name)
        {
            User user = (User)users.Select(x => x.Name == name);
            return user;
        }
    }
}

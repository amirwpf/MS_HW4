using HW4.DB;
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
        UserDataBase db;
        public UserRepository()
        {
            db = new UserDataBase();
            users = db.LoadUsersDB();
            
        }

        public void Create(string name,string phone,DateTime birthdate)
        {
            User user = new User();
            user.Name = name;
            user.Phone = phone;
            user.Birthdate = birthdate;
            user.CreateDate=DateTime.Now;
            if(user.Phone!="-1" && user.Birthdate.Year!=-1)
            {
                users.Add(user);
                db.Save(users);
            }
            
        }

        public void Delete(string name)
        {
            var user = SelectUserByName(name);
            users.Remove(user);
            db.Save(users);
        }

        public List<User> GetAll()
        {
            users=db.LoadUsersDB();
            return users;
        }

        public void Update(string name,string phone,DateTime birthDate)
        {
            var user = SelectUserByName(name);
            Delete(name);
            user.Phone=phone;
            user.Birthdate=birthDate;
            user.CreateDate= DateTime.Now;
            if (user.Phone != "-1" && user.Birthdate.Year != -1)
            {
                users.Add(user);
                db.Save(users);
            }
        }


        public User SelectUserByName(string name)
        {
            User user=new User();
            foreach (var item in users)
            {
                if (item.Name == name)
                    user = item;
            }
            return user;
        }
    }
}

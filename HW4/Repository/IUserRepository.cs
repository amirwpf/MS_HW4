using HW4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Repository
{
    public interface IUserRepository
    {
        public void Create(string name, string phone, DateTime birthdate);
        public List<User> GetAll();
        public void Update(string name, string phone, DateTime birthDate);
        public void Delete(string name);

    }
}

using CsvHelper;
using HW4.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW4.DB
{
    public class UserDataBase
    {
        public bool CreateFile()
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"UserDB.csv");
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                List<User> users = CreateFirstList();
                Save(users);
                //throw new FileNotFoundException(path);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Save(List<User> users)
        {
            CreateFile();
            string path = Path.Combine(Environment.CurrentDirectory, @"UserDB.csv");

            using var writer = new StreamWriter(path);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

            csv.WriteHeader<User>();
            csv.NextRecord();

            foreach (var item in users)
            {
                csv.WriteRecord(item);
                csv.NextRecord();
            }
            //csv.WriteRecords<User>(user.Where<User>(x=>x==x));

        }

        public List<User> LoadUsersDB()
        {
            List<User> users = new List<User>();
            CreateFile();
            string path = Path.Combine(Environment.CurrentDirectory, @"UserDB.csv");
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            
            users = csv.GetRecords<User>().ToList<User>();
            return users;

        }

        public List<User> CreateFirstList()
        {
            List<User> users = new List<User>()
            {
                new User
                {
                    Name = "User1",
                    Phone = "12345678910",
                    Birthdate = new DateTime(2000,1,2)
                },

                new User
                {
                    Name = "User2",
                    Phone = "2222222222",
                    Birthdate = new DateTime(2002,3,12)
                },

                new User
                {
                    Name = "User3",
                    Phone = "3333333333",
                    Birthdate = new DateTime(1990,10,2)
                }
            };

            return users;
        }
    }
}

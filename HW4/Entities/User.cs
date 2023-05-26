using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Entities
{
    public class User
    {
        public User()
        {
            this.Id = Guid.NewGuid();
        }
        [Name("Id")]
        public Guid Id { get; }

        [Name("Name")]
        public string Name { get; set; }

        [Name("Phone")]
        private string phone;

        [Name("Birth Date")]
        private DateTime birthDate;

        
        public string Phone
        {
            get { return phone; }
            set
            {
                if(value.Length==11)
                    phone = value;
            }
        }
        public DateTime Birthdate
        {
            get { return birthDate; }
            set
            {
                if (value<DateTime.Now)
                    birthDate = value;
            }
        }

        [Name("Create Date")]
        public DateTime CreateDate { get; set; }
    }
}

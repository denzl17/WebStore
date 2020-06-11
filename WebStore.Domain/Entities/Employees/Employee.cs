using System;
using System.ComponentModel.DataAnnotations;
using WebStore.Domain.Entities.Base;

namespace WebStore.Domain.Entities.Employees
{
    public class Employee : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public int Age { get; set; }

        public string Office { get; set; }

        public DateTime Birthdate { get; set; }

        public string Hobby { get; set; }
    }
}

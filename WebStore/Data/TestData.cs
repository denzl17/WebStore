using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Data
{
    public static class TestData
    {
        public static List<Employee> Employees { get; } = new List<Employee>
        {
           new Employee
            {
                Id = 1,
                Surname = "Иванов",
                FirstName = "Петр",
                Patronymic = "Иванович",
                Age = 50,
                Office = "Street1",
                Hobby = "Baseball",
                Birthdate = DateTime.Today.AddYears(-50).AddDays(-45)
            },
            new Employee
            {
                Id = 2,
                Surname = "Петров",
                FirstName = "Иван",
                Patronymic = "Петрович",
                Age = 25,
                Office = "Street2",
                Hobby = "Dancing",
                Birthdate = DateTime.Today.AddYears(-25).AddDays(56)
            },
            new Employee
            {
                Id = 3,
                Surname = "Сидоров",
                FirstName = "Евгений",
                Patronymic = "Сидорович",
                Age = 30,
                Office = "Street3",
                Hobby = "Bicycle",
                Birthdate = DateTime.Today.AddYears(-30).AddDays(12)
            },
        };
    }
}

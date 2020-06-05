using System;

namespace WebStore.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public int Age { get; set; }

        public string Office { get; set; }

        public DateTime Birthdate { get; set; }

        public string Hobby { get; set; }
    }
}

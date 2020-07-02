using System;
using System.ComponentModel.DataAnnotations;
using WebStore.Domain.Entities.Base;

namespace WebStore.Domain.Entities.Employees
{
    /// <summary>Информация о сотруднике</summary>
    public class Employee : BaseEntity
    {
        /// <summary>Имя</summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>Фамилия</summary>
        [Required]
        public string Surname { get; set; }

        /// <summary>Отчество</summary>
        public string Patronymic { get; set; }

        /// <summary>Возраст</summary>
        public int Age { get; set; }

        /// <summary>Адрес офиса</summary>
        public string Office { get; set; }

        /// <summary>День рожения</summary>
        public DateTime Birthdate { get; set; }

        /// <summary>Хобби</summary>
        public string Hobby { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.ViewModels
{
    public class EmployeeViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Имя является обязательным")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Длина имени должна быть от 3 до 200 символов")]
        [RegularExpression(@"([А-ЯЁ][а-яё]+)|([A-Z][a-z]+)", ErrorMessage = "Ошибка формата имени")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Фамилия является обязательной")]
        [MinLength(3, ErrorMessage = "Длина фамилии должна быть больше 3 символов")]
        public string Surname { get; set; }

        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Display(Name = "Возраст")]
        [Required]
        [Range(20, 80, ErrorMessage = "Возраст должен быть в пределах от 20 до 70 лет")]
        public int Age { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{

        //}

        [Display(Name = "Офис")]
        [Required(ErrorMessage = "Офис является обязательным")]
        [MinLength(5, ErrorMessage = "Длина офиса должна быть больше 5 символов")]
        public string Office { get; set; }

        public DateTime Birthdate { get; set; }

        [Display(Name = "Хобби")]
        [Required(ErrorMessage = "Хобби является обязательным")]
        [MinLength(10, ErrorMessage = "Длина офиса должна быть больше 10 символов")]
        public string Hobby { get; set; }
    }
}

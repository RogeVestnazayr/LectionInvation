using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LectionInvites.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Пожалуйста введите ваше имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Пожалуйста введите вашу фамилию")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Пожалуйста введите ваш емейл")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Введите коретный емейл")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Пожалуйста введите вашу групу")]
        public string Group { get; set; }
        [Required(ErrorMessage = "Пожалуйста определитесь с вашим выбором")]
        public bool? WillAttend { get; set; }
    }

}
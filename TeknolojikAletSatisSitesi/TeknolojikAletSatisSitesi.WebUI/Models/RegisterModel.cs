using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeknolojikAletSatisSitesi.WebUI.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Ad Soyad alanı zorunludur.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı alanı zorunludur.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Parola alanı zorunludur.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Tekrar parola alanı zorunludur.")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }

        [Required(ErrorMessage = "E-posta alanı zorunludur.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}

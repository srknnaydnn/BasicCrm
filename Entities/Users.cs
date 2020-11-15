using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Users
    {
        public int Id { get; set; }

        [StringLength(10, ErrorMessage = "{0}  {2} ile {1} Karakter Arasında Olmalıdır", MinimumLength = 6)]
        [Required(ErrorMessage = "Username Alanı Boş Bırakılmaz")]
        public string Username { get; set; }

        [EmailAddress(ErrorMessage ="Geçerli Bir E-posta Adresi Giriniz")]
    
        [Required(ErrorMessage = "Email Alanı Boş Bırakılmaz")]
        public string Email { get; set; }
       
        [StringLength(11,ErrorMessage = "{0} {2} ile {1} Karakter Arasında Olmalıdır")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password Alanı Boş Bırakılmaz")]
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password Alanı Boş Bırakılmaz")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor")]
        public string  ConfirmPassword { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    
        public class Customers
        {
        [Key]
        public int Id { get; set; }


        [StringLength(11, ErrorMessage = "{0} No  {1} Haneli olmalı.", MinimumLength = 11)]
        [RegularExpression(@"^[0-9]{11}$",ErrorMessage = "Lütfen Sayı Giriniz")]
        [Required(ErrorMessage = "T.C Alanı boş bırakılmaz")]
        
        public string  Tc{ get; set; }
     
        [MaxLength(50)]
        [Required(ErrorMessage = "Ad Alanı boş bırakılmaz")]
        public string Name { get; set; }
      
        [MaxLength(50)]

        [Required(ErrorMessage = "Soyad Alanı boş bırakılmaz")]
        public string Surname { get; set; }
      
        [StringLength(11,ErrorMessage =("{0} No {1} Haneli Olmalı"),MinimumLength=11)]
        [RegularExpression(@"^[0-9]{11}$", ErrorMessage = "Lütfen Sayı Giriniz")]
        [Required(ErrorMessage = "Telefon Alanı boş bırakılmaz")]
        public string Telefone { get; set; }
      
        [MaxLength(50)]

        [Required(ErrorMessage = "Adres Alanı boş bırakılmaz")]
        public string Adress { get; set; }
      
        [MaxLength(50)]
        [Required(ErrorMessage ="Şehir Alanı boş bırakılmaz")]
        public string City { get; set; }
    }
    }


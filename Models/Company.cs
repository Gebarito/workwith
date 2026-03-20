using System.ComponentModel.DataAnnotations;
using System.Numerics;
using Newtonsoft.Json;

namespace WebApp1.Models
{
    public class Company
    {
        public long Id {get; set;}

        [Required]
        [MaxLength(200)]
        public string RazaoSocial {get; set;} = String.Empty;
        
        [Required]
        [MaxLength(14)]
        public string Cnpj {get; set;} = String.Empty;

        [MaxLength(3000)]
        public string? Bio {get; set;}
       
    }
}
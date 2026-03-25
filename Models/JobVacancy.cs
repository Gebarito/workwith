using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace WebApp1.Models
{
    public class JobVacancy
    {
        public long Id {get; set;}

        [DisplayName("Razão Social")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        [MaxLength(200)]
        public string CompanyName {get; set;} = String.Empty;
        
        [Required(ErrorMessage = "Campo obrigatorio")]
        [MaxLength(14)]
        public string Cnpj {get; set;} = String.Empty;

        [DisplayName("Descricao")]
        [MaxLength(3000)]
        public string? Bio {get; set;}
        
        [DisplayName("Criado Em")]
        public DateTime CreatedAt {get; set;} = DateTime.Now;

    }
}
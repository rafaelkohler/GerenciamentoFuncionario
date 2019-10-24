using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeFuncionarios.Models
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Nome { get; set; }

        [InverseProperty("Lotacao")]
        public virtual IList<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();
        
        [Required]
        public virtual Funcionario Responsavel { get; set; }

        [ForeignKey("Responsavel")]
        [Display(Name = "Responsável")]
        public int ResponsavelId { get;set; }
    }
}

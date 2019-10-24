using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeFuncionarios.Models
{
    public class Funcionario: Pessoa
    {
        public Departamento Lotacao  { get; set; }

        [ForeignKey("Lotacao")]
        [Display(Name = "Lotação")]
        public int? LotacaoId { get; set; }
    }
}

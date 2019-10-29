using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeFuncionarios.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime? Fim { get; set; }

        [Display(Name="Título")]
        public String Titulo { get; set; }

        [Display(Name="Descrição")]
        public String Descricao { get; set; }

        public Funcionario Executor { get; set; }

        [ForeignKey("Executor")]
        [Display(Name ="Descrição")]
        public int? ExecutorId { get; set; }

        public Departamento Area { get; set; }
    }
}

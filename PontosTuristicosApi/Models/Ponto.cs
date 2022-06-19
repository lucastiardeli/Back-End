using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PontosTuristicosApi.Models
{
    public class Ponto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(40)]
        public string Cidade { get; set; }
        [Required]
        [StringLength(2)]
        public string Estado { get; set; }
        [Required]
        [MaxLength(80)]
        public string Rua { get; set; }
        [Required]
        [MaxLength(100)]
        public string Descricao { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NETCORE_CRUD_991.Models.Entities
{
    public class ValorLibra
    {
        [Key]
        [Required]
        public int IdValorLibra { get; set; }
        [Required]
        public float Valor { get; set; }
    }
}

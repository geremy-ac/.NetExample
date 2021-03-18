using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NETCORE_CRUD_991.Models.Entities
{
    public class Transportadoras
    {
        [Required]
        [Key]
        public int IdTransportadora { get; set; }
        [Required]
        [DisplayName("Nombre de Empresa Transportadora")]
        [Column("NombreTransportadora", TypeName = "nvarchar(50)")]
        public string Nombre { get; set; }
    }
}

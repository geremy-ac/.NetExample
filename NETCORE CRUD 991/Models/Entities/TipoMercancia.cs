using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NETCORE_CRUD_991.Models.Entities
{
    public class TipoMercancia
    {
        [Key]
        public int IdTipoMercancia { get; set; }
        [DisplayName("Nombre del tipo de Mercancia")]
        [Column("NombreTipoMercancia", TypeName ="nvarchar(50)")]
        [Required]
        public string Nombre { get; set; }
    }
}

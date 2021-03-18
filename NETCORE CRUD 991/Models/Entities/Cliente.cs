using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NETCORE_CRUD_991.Models.Entities
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [DisplayName("Nombre Completo")]
        [Column("NombreCliente", TypeName = "nvarchar(50)")]
        [Required]
        public string Nombre { get; set; }
        [DisplayName("Correo Electronico")]
        [EmailAddress]
        [Required]
        public string Correo { get; set; }
        [DisplayName("Direccion Entrega")]
        [Required]
        public string Direccion { get; set; }
    }
}

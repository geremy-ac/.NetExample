using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NETCORE_CRUD_991.Models.Entities
{
    public class Paquete
    {
        [Key]
        public int IdPaquete { get; set; }
        [Required]
        [DisplayName("Código del Paquete")]
        [Column(TypeName = "nvarchar(50)")]
        public string CodigoPaquete { get; set; }
        [Required]
        public float PesoLibra { get; set; }
        [Required]
        [DisplayName("Numero Casillero")]
        public int IdCliente { get; set; }
        [Required]
        [DisplayName("Valor de la Libra")]
        public int IdValorLibra { get; set; }
        [Required]
        [DisplayName("Estados")]
        public string Estado { get; set; }
        [Required]
        [DisplayName("Traking o Numero de Guia USA")]
        [Column(TypeName = "nvarchar(50)")]
        public int USA { get; set; }
        [Required]
        [DisplayName("Empresa Transportadora")]
        public int IdTransportadora { get; set; }
        [DisplayName("Tipo de Mercancia")]
        public int IdTipoMercancia { get; set; }
        [DisplayName("Numero de Guia COLOMBIA")]
        public int COL { get; set; }
        [DisplayName("Total a pagar")]
        public float ValorPagar { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace NETCORE_CRUD_991.Clases
{
    public class PaqueteDetalle
    {
        [DisplayName("Id del Paquete")]
        public int IdPaquete { get; set; }
        [DisplayName("Codigo del Paquete")]
        public string CodigoPaquete { get; set; }
        [DisplayName("Peso en Libras")]

        public float PesoLibra { get; set; }
        public string Casillero { get; set; }
        [DisplayName("Nombre Completo del casillero")]

        public string NombreCasillero { get; set; }
        public string Estado { get; set; }
        [DisplayName("Tracking")]

        public int USA { get; set; }
        [DisplayName("Empresa Transportadora")]

        public string Transportadora { get; set; }
        [DisplayName("Valor de la libra")]

        public float ValorLibra { get; set; }
        [DisplayName("Tipo de mercancia")]

        public string TipoMercancia { get; set; }
        [DisplayName("Guia COL")]

        public int COL { get; set; }
        [DisplayName("Valor Pagar")]

        public float ValorPagar { get; set; }

    }
}

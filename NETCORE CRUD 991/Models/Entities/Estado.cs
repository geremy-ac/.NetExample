using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NETCORE_CRUD_991.Models.Entities
{
    public class Estado
    {
        [Key]
        public int IdEstado { get; set; }
        public string Estados { get; set; }

    }
}

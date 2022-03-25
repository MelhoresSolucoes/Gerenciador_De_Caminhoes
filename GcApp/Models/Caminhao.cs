using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GcApp.Models
{
    public class Caminhao
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string IdModelo { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }

        public string DetalhesTecnicos { get; set; }
    }
}

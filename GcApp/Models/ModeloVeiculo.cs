using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GcApp.Models
{
    public class ModeloVeiculo
    {
        [Key]
        public int Id { get; set; }
        public string Modelo { get; set; }
        public bool Bloqueado { get; set; }
    }
}

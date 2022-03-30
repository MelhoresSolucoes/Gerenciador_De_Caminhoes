using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GcApp.Models
{
    public class Caminhao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdModeloVeiculo { get; set; }
        public ModeloVeiculo ModeloVeiculo { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public string DetalhesTecnicos { get; set; }

        
        //public List<ModeloVeiculo> ListModelosVeiculos { get; set; }
    }
}

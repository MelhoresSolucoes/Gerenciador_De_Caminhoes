using GcApp.Models;
using System.Collections.Generic;

namespace GcApp.ViewModels
{
    public class CaminhaoViewModel : Caminhao
    {
        public List<ModeloVeiculo> ListModelosVeiculos { get; set; }
    }
}

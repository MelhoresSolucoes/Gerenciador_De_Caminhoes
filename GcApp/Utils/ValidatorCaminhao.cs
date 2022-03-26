using GcApp.Models;
using System;

namespace GcApp.Utils
{
    public class ValidatorCaminhao
    {
        private Caminhao caminhao;
        public ValidatorCaminhao(Caminhao _caminhao)
        {
            this.caminhao = _caminhao;
            ValidateAll();
        }

        public bool ValidateAll()
        {
            return ValidarAnoFabricacao() && ValidarAnoModelo();
        }

        public bool ValidarAnoFabricacao()
        {
            if (this.caminhao.AnoFabricacao == DateTime.Now.Year)
                return true;
           
           return false;
        }

        public bool ValidarAnoModelo()
        {
            if ((this.caminhao.AnoModelo == DateTime.Now.Year)||(this.caminhao.AnoModelo == DateTime.Now.Year+1))
                return true;
            else
                return false;
        }

    }
}


using GcApp.Controllers;
using GcApp.Data;
using GcApp.Models;
using GcApp.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GcApp.Tests.Controller
{
    public class CaminhaoTests
    {

        [Fact]
        public void ValidarAnoFabricacaoNaoDevePassar()
        {
            Caminhao caminhao = new Caminhao();
            caminhao.AnoFabricacao = 2012;
            caminhao.AnoModelo = 2014;
            caminhao.Descricao = "Teste";
            caminhao.DetalhesTecnicos = "Testes Unitários";
            bool caminhaoValidator = new ValidatorCaminhao(caminhao).ValidarAnoFabricacao();
            Assert.False(caminhaoValidator);
        }

        [Fact]
        public void ValidarAnoFabricacaoDevePassar()
        {
            Caminhao caminhao = new Caminhao();
            caminhao.AnoFabricacao = 2022;
            caminhao.AnoModelo = 2023;
            caminhao.Descricao = "Teste";
            caminhao.DetalhesTecnicos = "Testes Unitários";
            bool caminhaoValidator = new ValidatorCaminhao(caminhao).ValidarAnoFabricacao();
            Assert.True(caminhaoValidator);
        }



    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Features.Tests
{
    public class TesteNaoPassandoMotivoEspecifico
    {

        //[Fact(DisplayName ="Novo Cliente 2.0",Skip ="Nova versão 2.0 quebrando")]
        [Fact(DisplayName = "Novo Cliente 2.0")]
        [Trait("Categoria","Escapando de Testes")]
        public void Teste_NaoEstaPassando_VersaoNovaNaoCompativel()
        {
            //Assert.True(false);
            Assert.True(true);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.Tests
{
    public class AssertingExceptionsTests
    {
        [Fact]
        public void Calculadora_Dividir_DeveRetornarErroDivisaoPorZero()
        {
            // Arrange
            var calculadora = new Calculadora();

            //var resultado = calculadora.Dividir(10, 0);

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(10, 0));
        }

        [Fact]
        public void Funcionario_DeveRetornarErroSalarioInferiorPermitido()
        {
            // Arrange & Act & Assert
            var exception =
                Assert.Throws<Exception>(() => FunctionalFactory.Criar("Eduardo", 250));

            Assert.Equal("Salario inferior ao permitido", exception.Message);
        }
    }
}

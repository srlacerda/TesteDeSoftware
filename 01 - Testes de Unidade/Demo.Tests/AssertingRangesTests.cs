using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.Tests
{
    public class AssertingRangesTests
    {
        [Theory]
        [InlineData(700)]
        [InlineData(1500)]
        [InlineData(2000)]
        [InlineData(7500)]
        [InlineData(8000)]
        [InlineData(15000)]

        public void Funcionario_Salario_FaixasSalariaisDevemRespeitarNivelProfissional(double salario)
        {
            // Arrange & Act
            var funcionario = new Funcionario("Eduardo", salario);

            // Assert
            if (funcionario.NivelProfisional == NivelProfisional.Junior)
                Assert.InRange(funcionario.Salario, 500, 1999);

            if (funcionario.NivelProfisional == NivelProfisional.Pleno)
                Assert.InRange(funcionario.Salario, 2000, 7999);

            if (funcionario.NivelProfisional == NivelProfisional.Senior)
                Assert.InRange(funcionario.Salario, 8000, double.MaxValue);

            Assert.NotInRange(funcionario.Salario, 0, 499);
        }
    }
}

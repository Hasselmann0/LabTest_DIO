using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;
using Xunit;

namespace CalculadoraTestes
{
    public class ValidaStringsTests
    {
        private readonly ValidaStrings _validaStrings;

        public ValidaStringsTests()
        {
            _validaStrings = new ValidaStrings();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            // Arrange
            string texto = "Ola";
            // Act
            var resultado = _validaStrings.ContarCaracteres(texto);
            // Assert
            Assert.Equal(3, resultado);
        }
    }
}
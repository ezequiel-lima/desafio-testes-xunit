using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Util;

namespace Alura.Adopet.Testes
{
    public class PetAPartirDoCsvTest
    {
        [Fact]
        public void QuandoStringForValidaDeveRetornatUmPet()
        {
            //Arrange
            string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;1";
            
            //Act
            Pet pet = linha.ConverteDoTexto();

            //Assert
            Assert.NotNull(pet);
        }

        [Fact]
        public void QuandoStringForNullDeveRetornatUmException()
        {
            //Arrange
            string linha = null;

            //Act and Assert
            Assert.Throws<ArgumentNullException>(() => linha.ConverteDoTexto());
        }

        [Fact]
        public void QuandoStringForVaziaDeveRetornatUmException()
        {
            //Arrange
            string linha = "";

            //Act and Assert
            Assert.Throws<ArgumentNullException>(() => linha.ConverteDoTexto());
        }

        [Fact]
        public void QuandoStringConterQuantidadeInsuficienteDeCampoDeveRetornatUmException()
        {
            //Arrange
            string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima";

            //Act and //Assert
            Assert.Throws<Exception>(() => linha.ConverteDoTexto());
        }

        [Fact]
        public void QuandoStringComGUIDInvalidoDeveLancarFormatException()
        {
            // Arrange
            string linha = "GUID_Inválido;Lima;1";

            // Act & Assert
            Assert.Throws<FormatException>(() => linha.ConverteDoTexto());
        }
    }
}

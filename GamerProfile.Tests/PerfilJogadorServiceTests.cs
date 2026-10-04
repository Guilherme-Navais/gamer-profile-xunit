using Xunit;
using GamerProfile.App; // Permite aceder à classe do projeto de Produção

namespace GamerProfile.Tests
{
    public class PerfilJogadorServiceTests
    {
        [Fact]
        public void Teste1_GerarTagUsuario_FormatoCorreto()
        {
            // Arrange
            var service = new PerfilJogadorService();
            
            // Act
            var resultado = service.GerarTagUsuario("Aragorn", "1042");
            
            // Assert
            // Valida se GerarTagUsuario gera a formatação correta utilizando Assert.Equal[cite: 2].
            Assert.Equal("Aragorn#1042", resultado); 
        }

        [Fact]
        public void Teste2_CalcularXPTotal_SomaEBonusCorretos()
        {
            // Arrange
            var service = new PerfilJogadorService();
            
            // Act
            var resultado = service.CalcularXPTotal(200, 300);
            
            // Assert
            // Valida se CalcularXPTotal realiza a soma e aplica o bônus corretamente utilizando Assert.Equal.
            Assert.Equal(600, resultado); 
        }

        [Fact]
        public void Teste3_EEligivelParaRanked_RegrasDeElegibilidade()
        {
            // Arrange
            var service = new PerfilJogadorService();
            
            // Assert
            // Valida as regras de elegibilidade para partidas ranqueadas utilizando Assert.True(...) para níveis a partir de 15[cite: 3].
            Assert.True(service.EEligivelParaRanked(15)); 
            
            // Valida utilizando Assert.False(...) para níveis abaixo de 15[cite: 3].
            Assert.False(service.EEligivelParaRanked(14)); 
        }
    }
}
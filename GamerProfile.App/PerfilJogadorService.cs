namespace GamerProfile.App
{
    public class PerfilJogadorService
    {
        // Concatena o nickname e o codigo com o caractere #[cite: 2].
        public string GerarTagUsuario(string nickname, string codigo)
        {
            return $"{nickname}#{codigo}";
        }

        // Soma o XP de duas fases e aplica um bônus fixo de 100 pontos[cite: 2].
        public int CalcularXPTotal(int xpFase1, int xpFase2)
        {
            return xpFase1 + xpFase2 + 100;
        }

        // Retorna true se o nível do jogador for maior ou igual a 15, e false caso contrário[cite: 2].
        public bool EEligivelParaRanked(int nivelJogador)
        {
            return nivelJogador >= 15;
        }
    }
}
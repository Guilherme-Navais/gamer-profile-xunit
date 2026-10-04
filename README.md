# Gamer Profile

Solução via linha de comando para gerenciar um serviço de cadastro de jogadores.

## Testes Unitários Realizados
O projeto utiliza xUnit para validar as regras de negócio através de três testes:
* **Teste de String (GerarTagUsuario):** Valida se o sistema gera a formatação correta, unindo o nickname e o código com a hashtag (ex: Nickname#0000).
* **Teste de Inteiro (CalcularXPTotal):** Valida se a soma do XP de duas fases é realizada corretamente junto com a aplicação do bônus fixo de 100 pontos.
* **Teste Booleano (EEligivelParaRanked):** Valida as regras de elegibilidade, retornando verdadeiro para níveis a partir de 15 e falso para níveis inferiores.

## Instruções de Execução
Para executar a validação dos testes, abra o terminal na pasta raiz da solução e rode o seguinte comando:
`dotnet test`

# Jogo de Adivinha��o

![](https://imgur.com/I4q8U4V.gif)

## Projeto

Desenvolvido durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2025

---
## Detalhes

No in�cio do jogo, � gerado um n�mero secreto aleat�rio entre 1 e 20. Os jogadores devem ent�o tentar adivinhar esse n�mero dentro de um n�mero limitado de tentativas, que varia de acordo com a dificuldade escolhida. A cada tentativa errada, dicas s�o fornecidas para ajudar a direcionar as pr�ximas tentativas.

Os n�veis de dificuldade ser�o:�

1. F�cil = 15 chances�
2. M�dio = 10 chances�    
3. Dif�cil = 5 chances

---
## Entrada

Os jogadores interagem com o jogo por meio do console, digitando n�meros e recebendo feedback instant�neo sobre suas escolhas. O jogo termina quando o jogador adivinha o n�mero secreto ou quando todas as tentativas s�o esgotadas.

---
## Funcionalidades

- **Gera��o de N�mero Secreto:** No in�cio de cada jogo, um n�mero secreto � gerado aleatoriamente entre 1 e 20.
- **Sele��o de Dificuldade:** Os jogadores podem escolher entre tr�s n�veis de dificuldade (F�cil, M�dio, Dif�cil), que influenciam o n�mero de tentativas dispon�veis.
- **Feedback Instant�neo:** Ap�s cada tentativa, o jogo fornece feedback indicando se o n�mero escolhido � maior ou menor que o n�mero secreto.
---
## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.
---
## Como Usar

#### Clone o Reposit�rio
```
git clone https://github.com/academiadoprogramador-fullstack/jogo-de-adivinhacao-2025.git
```

#### Navegue at� a pasta raiz da solu��o
```
cd jogo-de-adivinhacao-2025
```

#### Restaure as depend�ncias
```
dotnet restore
```

#### Navegue at� a pasta do projeto
```
cd JogoDaAdivinhacao.ConsoleApp
```

#### Execute o projeto
```
dotnet run
```
# 🛡️ Arena dos Heróis - RPG Character Engine

Este projeto foi desenvolvido como parte da disciplina de **Tópicos Especiais de Sistemas** no curso de **Análise e Desenvolvimento de Sistemas (ADS)** da Universidade Positivo.

Trata-se de um motor de criação de personagens para RPG baseado em console, onde o foco principal não é apenas a funcionalidade, mas a aplicação de **Padrões de Projeto (Design Patterns)** e princípios de **Arquitetura de Software Clean**.

---

## 🚀 Tecnologias e Conceitos Aplicados

O sistema foi construído com **C#** e **.NET**, demonstrando domínio em:

### 🧩 Padrões de Projeto (Design Patterns)
* **Strategy Pattern:** Implementado na interface `IDistribuicao`. Ele isola a lógica de geração de atributos, permitindo que o sistema suporte múltiplos métodos (Aleatório, Livre ou Pré-definido) sem acoplamento.
* **Factory Method:** Centralizado na `ClasseFactory`, permitindo a criação dinâmica de especializações de heróis (Guerreiro, Mago, Arqueiro e Assassino) de forma desacoplada.

### 🏗️ Arquitetura e POO
* **Abstração e Herança:** Uso de classes abstratas (`ClasseBase`) para definir contratos de comportamento.
* **Polimorfismo:** Tratamento genérico de classes de personagens e estratégias de distribuição em tempo de execução.
* **Encapsulamento:** Modelagem de atributos com lógica própria para cálculo de modificadores.
* **SOLID:** Foco no princípio *Open/Closed* (Aberto para expansão, Fechado para modificação).

---

## 🎮 Funcionalidades

1.  **Criação de Identidade:** Nomeação e escolha de classe com atributos base distintos.
2.  **Sistemas de Atributos:**
    * **Aleatório:** Rola 2d6 para cada status (Sorte/RNG).
    * **Distribuição Livre:** O jogador gerencia um "budget" de 60 pontos com validações de limites mínimos e máximos.
    * **Perfil Pré-definido:** Arquétipos balanceados (Tanque, Ágil, Sábio).
3.  **Cálculo Dinâmico de Vida (PV):** O HP inicial é calculado com base no dado de vida da classe somado ao modificador de Resistência gerado.
4.  **Interface de Console Rica:** Uso de cores e formatação tabular para melhor UX no terminal.

---

## 🛠️ Como Executar

1. Certifique-se de ter o **SDK do .NET 6.0** (ou superior) instalado.
2. Clone o repositório:
   ```bash
   git clone [https://github.com/seu-usuario/arena-dos-herois.git](https://github.com/seu-usuario/arena-dos-herois.git)
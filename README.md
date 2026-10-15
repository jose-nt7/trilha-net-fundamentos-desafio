# 🚗 Sistema de Estacionamento — Desafio .NET DIO

Projeto desenvolvido durante a **Trilha .NET da Digital Innovation One (DIO)**, com o objetivo de aplicar os fundamentos da linguagem C# na construção de um sistema de gerenciamento de estacionamento.

## 📌 Sobre o projeto

O sistema permite gerenciar veículos estacionados por meio de uma aplicação de console desenvolvida em C#.

A aplicação oferece funcionalidades de cadastro, remoção e listagem de veículos, além de calcular automaticamente o valor cobrado de acordo com o tempo de permanência.

## 🚀 Funcionalidades

- Cadastrar veículos utilizando suas placas.
- Impedir o cadastro de placas duplicadas.
- Listar todos os veículos estacionados.
- Remover veículos cadastrados.
- Calcular o valor total do estacionamento.
- Validar entradas e valores informados.
- Identificar placas independentemente de letras maiúsculas ou minúsculas.
- Navegar por um menu interativo.

## 🛠️ Tecnologias utilizadas

- C#
- .NET 6
- Visual Studio Code
- Git e GitHub

## 🧠 Conceitos aplicados

- Classes, objetos e construtores.
- Encapsulamento de atributos.
- Listas genéricas (`List<string>`).
- Estruturas condicionais (`if`, `else`, `switch`).
- Estruturas de repetição (`while`, `foreach`).
- Métodos e manipulação de strings.
- Expressões LINQ.
- Tratamento de entradas com `TryParse()`.
- Operações matemáticas utilizando `decimal`.

## 📂 Estrutura do projeto

```text
trilha-net-fundamentos-desafio/
├── Models/
│   └── Estacionamento.cs
├── docs/
│   └── README-DIO.md
├── Program.cs
├── README.md
└── [arquivo do projeto .csproj]
```

## ▶️ Como executar

**1. Clone o repositório:**

```bash
git clone https://github.com/jose-nt7/trilha-net-fundamentos-desafio.git
```

**2. Acesse a pasta do projeto:**

```bash
cd trilha-net-fundamentos-desafio
```

**3. Localize a pasta que contém o arquivo `.csproj` e execute:**

```bash
dotnet run
```

> O projeto utiliza .NET 6, versão que já encerrou seu período de suporte. Para executar a aplicação, utilize um ambiente .NET compatível.

## 💻 Exemplo de funcionamento

```text
====================================
   SISTEMA DE ESTACIONAMENTO - DIO
====================================
Digite o preço inicial: R$ 5
Digite o preço por hora: R$ 2

====================================
       MENU DO ESTACIONAMENTO
====================================
1 - Cadastrar veículo
2 - Remover veículo
3 - Listar veículos
4 - Encerrar
====================================
Escolha uma opção: 1

Digite a placa do veículo para estacionar:
ABC1234
Veículo com a placa ABC1234 adicionado com sucesso.
```

### Exemplo de cálculo

Considerando os valores:

- Preço inicial: R$ 5,00
- Preço por hora: R$ 2,00
- Permanência: 3 horas

**Fórmula:**

`Valor total = Preço inicial + (Preço por hora × Horas)`

**Resultado:** R$ 11,00.

## 📚 Desafio original

Este projeto foi desenvolvido com base no desafio educacional da Digital Innovation One.

A documentação original está preservada em [README-DIO.md](docs/README-DIO.md).

## 👨‍💻 Autor

**José Ribeiro**

Desenvolvedor com foco em desenvolvimento de software e aprimoramento de conhecimentos em C#, .NET e boas práticas de programação.

GitHub: [jose-nt7](https://github.com/jose-nt7)

---

Projeto desenvolvido para fins educacionais e aprimoramento técnico.
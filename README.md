# 💈 BarbeariaApp

![Status](https://img.shields.io/badge/status-em%20desenvolvimento-yellow)
![C#](https://img.shields.io/badge/C%23-.NET-blue)
![POO](https://img.shields.io/badge/POO-aplicado-success)

Sistema simples de gerenciamento de barbearia desenvolvido em C# com foco em praticar Programação Orientada a Objetos (POO).

---

## 🚀 Sobre o projeto

Este projeto foi criado com o objetivo de reforçar conceitos fundamentais de POO, como herança, abstração, encapsulamento e uso de interfaces.

A aplicação funciona via terminal e permite o gerenciamento básico de clientes e agendamentos de serviços em uma barbearia.

> ⚠️ Este projeto não utiliza banco de dados — os dados são armazenados em memória durante a execução.

---

## ⚙️ Funcionalidades

- ✅ Cadastro de clientes  
- ✅ Criação de agendamentos  
- ✅ Listagem de agendamentos  
- ✅ Seleção de barbeiros  
- ✅ Escolha de serviços (Corte ou Barba)  

---

## 🧠 Conceitos aplicados

- 🔹 **Herança**  
  - `Pessoa` → `Cliente` e `Barbeiro`

- 🔹 **Abstração**  
  - Classe abstrata `Pessoa`

- 🔹 **Interface**  
  - `IServico` implementada por `Corte` e `Barba`

- 🔹 **Encapsulamento**

- 🔹 **Separação de responsabilidades**
  - Organização em `Models` e `Services`

---

## 🏗️ Estrutura do projeto
```
BarbeariaApp/
│
├── Models/
│ ├── Pessoa.cs
│ ├── Cliente.cs
│ ├── Barbeiro.cs
│ └── Agendamento.cs
│
├── Services/
│ ├── IServico.cs
│ ├── Corte.cs
│ └── Barba.cs
│
└── Program.cs
```

---

## ▶️ Como executar

### Pré-requisitos:
- .NET SDK 6 ou superior

### Passos:

```
# Clone o repositório
git clone https://github.com/DaviMdr/barbearia-app.git

# Acesse a pasta
cd barbearia-app

# Execute o projeto
dotnet run
```

## 🔮 Melhorias futuras

Este projeto será evoluído para se tornar uma aplicação mais próxima de um cenário real:

- 🔹 Integração com banco de dados (SQLite ou SQL Server)
- 🔹 Criação de API com ASP.NET Core
- 🔹 Interface gráfica (Web ou Desktop)
- 🔹 Persistência de dados
- 🔹 Validações mais robustas
- 🔹 Sistema de autenticação

## 📚 Objetivo

Este projeto faz parte dos meus estudos em desenvolvimento backend e foi criado para consolidar conhecimentos em C# e boas práticas de programação.

## 👨‍💻 Autor

Desenvolvido por Davi Modro
```
🔗 LinkedIn: https://www.linkedin.com/in/davi-mendon%C3%A7a-modro-28a828370/ 
🔗 GitHub: https://github.com/DaviMdr
```

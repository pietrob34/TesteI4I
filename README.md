# TesteI4I - Teste tecnico para vaga de estagio

## Sistema de Gestão de Tarefas

Este é um sistema simples de gestão de tarefas desenvolvido em C# para rodar via console.

## Funcionalidades

**Cadastrar Tarefa**
- Solicita código, título, descrição, data de vencimento e situação.
  - Validação:
    - Título com no máximo 50 caracteres
    - Data de vencimento deve ser futura
    - Situação deve ser: `Pendente`, `Em andamento` ou `Concluída`

 **Listar Tarefas**
  - Mostra todas as tarefas com:
    - Código
    - Título
    - Descrição
    - Data de vencimento
    - Situação
   
  **Excluir Tarefa**
  - Permite remover uma tarefa pelo código.

  **Sair do Sistema**
  - Finaliza o programa de forma segura.


## Como executar 

### Requisitos
- [.NET 8.0 SDK ou superior](https://dotnet.microsoft.com/download/dotnet/8.0)


### Passos
1. Clone o repositório:
   ```bash
   git clone https://github.com/pietrob34/TesteI4I.git
   
2. Acesse a pasta do projeto:
   ```bash
   cd TesteI4I/TesteI4I
   
3. Execute o programa
   ```bash
   dotnet run


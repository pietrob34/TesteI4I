using System.ComponentModel;
using TesteI4I;

Boolean run = true;
List<Tarefa> tarefas = new List<Tarefa>();

//Função para verificar o limite maximo de 50 caracteres no titulo
String VerificacaoQuantidadeDeCaracteresDoTitulo()
{
    Console.WriteLine("Qual o titulo da tarefa?");
    string titulo = Console.ReadLine();
    if (titulo.Length <= 50)
    {
        return titulo;
    }
    else
    {
        Console.WriteLine("Titulo deve ter menos de 50 caracteres. Favor digitar novamente");
        return VerificacaoQuantidadeDeCaracteresDoTitulo();
    }
}

//Função para verificar se a data de vencimento é superior a atual
DateOnly VerificacaoDataFutura()
{
    Console.WriteLine("Qual a data de vencimento da tarefa? Formato: AAAA-MM-DD");
    DateOnly dataVencimento = DateOnly.Parse(Console.ReadLine());
    if (dataVencimento > DateOnly.FromDateTime(DateTime.Now))
    {
        return dataVencimento;
    }
    else
    {
        Console.WriteLine("Data precisa ser futura. Favor digitar novamente");
        return VerificacaoDataFutura();
    }
}

//Função para escolher uma das 3 situações disponiveis
String VerificacaoSituacao()
{
    Console.WriteLine("Qual a situação da tarefa");
    Console.WriteLine("1 = Pendente");
    Console.WriteLine("2 = Em andamento");
    Console.WriteLine("3 = Concluída");
    int situacao = Convert.ToInt32(Console.ReadLine());
    switch (situacao)
    {
        case 1:
            return "Pendente";
            break;
        case 2:
            return "Em andamento";
            break;
        case 3:
            return "Concluída";
        default:
            Console.WriteLine("Favor escolher entre as 3 opções");
            return VerificacaoSituacao();
    }
}

//Função para criar nova tarefa
void CriarNovaTarefa()
{
    Tarefa tarefa = new Tarefa();
    Console.WriteLine("Qual o codigo da tarefa?");
    tarefa.Codigo = Convert.ToInt32(Console.ReadLine());
    tarefa.Titulo = VerificacaoQuantidadeDeCaracteresDoTitulo();
    Console.WriteLine("Qual a descrição da tarefa?");
    tarefa.Descricao = Console.ReadLine();
    tarefa.DataVencimento = VerificacaoDataFutura();
    tarefa.Situacao = VerificacaoSituacao();
    Console.WriteLine("Item adicionado com sucesso");
    tarefas.Add(tarefa);
}

//Função para listar tarefas
void MostrarTarefas(List<Tarefa> tarefas)
{
    foreach (var tarefa in tarefas)
    {
        Console.WriteLine($"Codigo: {tarefa.Codigo}");
        Console.WriteLine($"Titulo: {tarefa.Titulo}");
        Console.WriteLine($"Descrição: {tarefa.Descricao}");
        Console.WriteLine($"Data de Vencimento: {tarefa.DataVencimento}");
        Console.WriteLine($"Situação: {tarefa.Situacao}");
        Console.WriteLine("----------------------------");
        Console.WriteLine();
    }
}

//Função para excluir tarefa
void ExcluirTarefas()
{
    MostrarTarefas(tarefas);
    Console.WriteLine("Digite o codigo da tarefa que voce quer excluir");
    int codigo = Convert.ToInt32(Console.ReadLine());
    int removido = tarefas.RemoveAll(t  => t.Codigo == codigo);
    if (removido > 0)
    {
        Console.WriteLine("Tarefa Removida");
    }
    else
    {
        Console.WriteLine("Tarefa não encontrada. Tente novamente");
        ExcluirTarefas();
    }
}

while (run)
{
    //Menu
    Console.WriteLine("Bem vindo ao Sistema de Gestão de Tarefas");
    Console.WriteLine("1. Criar nova tarefa");
    Console.WriteLine("2. Listar todas as tarefas");
    Console.WriteLine("3. Excluir uma tarefa");
    Console.WriteLine("4. Sair");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            CriarNovaTarefa();      
            break;
        case 2:
            MostrarTarefas(tarefas);
            break;
        case 3:
            ExcluirTarefas();
            break;
        case 4:
            run = false;
            break;
        default:
            Console.WriteLine("Escolha invalida");
            break;
    }
}

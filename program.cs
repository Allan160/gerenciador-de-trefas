using System;
using Layout;
using GerenciarTarefa;

class Program
{
    static void Main()
    {
        bool sair = false;

        while (!sair)
        {
            // Exibe o cabeçalho
            Layout.Formatação.ImprimirCabecalho();

            // Exibe o menu de opções
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adicionar Tarefa");
            Console.WriteLine("2 - Concluir Tarefa");
            Console.WriteLine("3 - Listar Tarefas");
            Console.WriteLine("4 - Remover Tarefa");
            Console.WriteLine("5 - Sair");

            // Lê a opção do usuário
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    // Adicionar Tarefa
                    Console.Write("Digite a descrição da tarefa: ");
                    string descricao = Console.ReadLine();
                    GerenciarTarefa.GerenciarTarefas.AdicionarTarefa(descricao);
                    break;

                case "2":
                    // Concluir Tarefa
                    Console.Write("Digite o ID da tarefa a ser concluída: ");
                    if (int.TryParse(Console.ReadLine(), out int idConcluir))
                    {
                        GerenciarTarefa.GerenciarTarefas.ConcluirTarefa(idConcluir);
                    }
                    else
                    {
                        Console.WriteLine("ID inválido.");
                    }
                    break;

                case "3":
                    // Listar Tarefas
                    GerenciarTarefa.GerenciarTarefas.ListarTarefas();
                    break;

                case "4":
                    // Remover Tarefa
                    Console.Write("Digite o ID da tarefa a ser removida: ");
                    if (int.TryParse(Console.ReadLine(), out int idRemover))
                    {
                        GerenciarTarefa.GerenciarTarefas.RemoverTarefa(idRemover);
                    }
                    else
                    {
                        Console.WriteLine("ID inválido.");
                    }
                    break;

                case "5":
                    // Sair
                    sair = true;
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            // Espera o usuário pressionar uma tecla antes de continuar
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}

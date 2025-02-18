using System;
using System.Collections.Generic;
using Tarefas;

namespace GerenciarTarefa
{
    public class GerenciarTarefas
    {
        private static List<Tarefa> tarefas = new List<Tarefa>();
        private static int contadorId = 1;

        // Método para adicionar uma tarefa
        public static void AdicionarTarefa(string descricao)
        {
            Tarefa novaTarefa = new Tarefa(contadorId++, descricao);
            tarefas.Add(novaTarefa);
            Console.WriteLine("Tarefa adicionada com sucesso.");
        }

        // Método para concluir uma tarefa
        public static void ConcluirTarefa(int id)
        {
            var tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefa.Concluida = true;
                Console.WriteLine("Tarefa concluída.");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }

        // Método para listar todas as tarefas
        public static void ListarTarefas()
        {
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa encontrada.");
            }
            else
            {
                foreach (var tarefa in tarefas)
                {
                    tarefa.ExibirTarefa();
                }
            }
        }

        // Método para remover uma tarefa
        public static void RemoverTarefa(int id)
        {
            var tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
                Console.WriteLine("Tarefa removida.");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }
    }
}


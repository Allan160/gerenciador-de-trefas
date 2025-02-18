using System;

namespace Layout
{
    public class Formatação
    {
        // Método para exibir uma mensagem com uma cor específica
        public static void Cor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }

        // Método para imprimir o cabeçalho
        public static void ImprimirCabecalho()
        {
            Console.Clear();
            Cor("===== Sistema de Gerenciamento de Tarefas =====", ConsoleColor.Cyan);
            Console.WriteLine();
        }
    }
}

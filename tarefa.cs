namespace Tarefas
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }

        // Construtor da classe Tarefa
        public Tarefa(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
            Concluida = false;
        }

        // Método para exibir as informações da tarefa
        public void ExibirTarefa()
        {
            Console.WriteLine($"ID: {Id} - Descrição: {Descricao} - Status: {(Concluida ? "Concluída" : "Pendente")}");
        }
    }
}

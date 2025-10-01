namespace Priorix.Priorix.Core.Interfaces.IRepositories
{
    public interface ITaskRepository
    {
        TarefaOutputDTO Cadastrar(TarefaInputDTO dto);
        TarefaOutputDTO Priorizar(int id, string metodo); 
        IEnumerable<TarefaOutputDTO> Listar();
        RelatorioDTO GerarRelatorio();
    }
}

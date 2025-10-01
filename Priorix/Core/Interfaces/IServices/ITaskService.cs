namespace Priorix.Priorix.Core.Interfaces.IServices
{
    public interface ITaskService
    {
          TaskOutputDTO Cadastrar(TaskInputDTO dto);
          TaskOutputDTO Priorizar(int id, string metodo); 
          IEnumerable<TaskOutputDTO> Listar();
          RelatorioDTO GerarRelatorio()
    }
}

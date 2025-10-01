namespace Priorix.Priorix.Core.Interfaces.IServices
{
    public interface ITaskService
    {
          TaskOutputDTO Cadastrar(TaskInputDTO dto);
          TaskOutputDTO Priority(int id, string metodo); 
          IEnumerable<TaskOutputDTO> Listar();
          RelatorioDTO GerarRelatorio()
    }
}

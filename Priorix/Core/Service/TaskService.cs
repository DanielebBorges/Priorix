namespace Priorix.Priorix.Core.Service
{
    public class TaskService
    {
        private readonly ITaskRepository _repository;
    private readonly IMapper _mapper;

    public TaskService(ITaskRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public TaskOutputDTO Cadastrar(TaskInputDTO dto)
    {
        var task = _mapper.Map<Task>(dto);
        task.DataCriacao = DateTime.UtcNow;
        _repository.Add(task);
        return _mapper.Map<TarefaOutputDTO>(task);
    }

    public TarefaOutputDTO Priorizar(int id, string metodo)
    {
        var task = _repository.GetById(id);
        if (task == null)
            throw new Exception("Tarefa não encontrada");

        double prioridade = metodo.ToUpper() switch
        {
            "RICE" => (tarefa.Reach * tarefa.Impact * tarefa.Confidence) / task.Effort,
            "WSJF" => (tarefa.ValorNegocio + tarefa.Urgencia + tarefa.Risco) / task.Effort,
            _ => throw new ArgumentException("Método de priorização inválido")
        };

        task.Priority = priority;
        task.JustificativaIA = $"Prioridade calculada usando o método {metodo}.";
        _repository.Update(task);

        return _mapper.Map<TaskOutputDTO>(tarefa);
    }

    public IEnumerable<TaskOutputDTO> Listar()
    {
        var task = _repository.GetAll();
        return _mapper.Map<IEnumerable<TaskOutputDTO>>(task);
    }

    public RelatorioDTO GerarRelatorio()
    {
        var task = _repository.GetAll();
        var concluidas = task.Where(t => t.DataConclusao.HasValue).ToList();

        double mediaConclusao = concluidas.Any()
            ? concluidas.Average(t => (t.DataConclusao.Value - t.DataCriacao).TotalDays)
            : 0;

        return new RelatorioDTO
        {
            TotalTask = task.Count(),
            TaskConcluidas = concluidas.Count,
            MediaDiasConclusao = Math.Round(mediaConclusao, 2),
            TaskPriorityAlta = task.Count(t => t.Priority >= 8)
    }
}

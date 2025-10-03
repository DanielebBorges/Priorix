// Exemplo no PriorizationController.cs
[HttpPost]
public IActionResult Calculate([FromBody] RiceInputDto input)
{
    // A Injeção de Dependência fornece a implementação concreta do serviço.
    _priorizationService.CalculateAndSaveMetrics(input.TaskId, ...);
    return Ok();
}
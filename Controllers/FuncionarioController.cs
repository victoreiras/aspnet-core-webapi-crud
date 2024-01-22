using ASPNET_CORE_WEBAPI_CRUD.Models;
using ASPNET_CORE_WEBAPI_CRUD.Services.FuncionarioService;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_CORE_WEBAPI_CRUD.Controllers;

public class FuncionarioController : ControllerBase
{
    private readonly IFuncionarioService _funcionarioService;

    public FuncionarioController(IFuncionarioService funcionarioService)
    {
        _funcionarioService = funcionarioService;
    }

    [HttpGet("GetFuncionarios")]
    public IActionResult GetFuncionarios()
    {
        return Ok(_funcionarioService.GetFuncionarios());
    }

    [HttpGet("GetFuncionarioById/{id}")]
    public IActionResult GetFuncionarioById(int id)
    {
        return Ok(_funcionarioService.GetFuncionarioById(id));
    }

    [HttpPost("CreateFuncionario")]
    public IActionResult CreateFuncionario(FuncionarioModel funcionario)
    {
        return Ok(_funcionarioService.CreateFuncionario(funcionario));
    }


    [HttpPut("UpdateFuncionario")]
    public IActionResult UpdateFuncionario(FuncionarioModel funcionario)
    {
        return Ok(_funcionarioService.UpdateFuncionario(funcionario));
    }

    [HttpDelete("DeleteFuncionario/{id}")]
    public IActionResult DeleteFuncionario(int id)
    {
        return Ok(_funcionarioService.DeleteFuncionario(id));
    }

    [HttpPut("InativaFuncionario/{id}")]
    public IActionResult InativaFuncionario(int id)
    {
        return Ok(_funcionarioService.InativaFuncionario(id));
    }
}
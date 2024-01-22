using ASPNET_CORE_WEBAPI_CRUD.Models;

namespace ASPNET_CORE_WEBAPI_CRUD.Services.FuncionarioService;

public interface IFuncionarioService
{
    ServiceResponse<List<FuncionarioModel>> GetFuncionarios();
    ServiceResponse<List<FuncionarioModel>> CreateFuncionario(FuncionarioModel funcionario);
    ServiceResponse<FuncionarioModel> GetFuncionarioById(int id);
    ServiceResponse<List<FuncionarioModel>> UpdateFuncionario(FuncionarioModel funcionario);
    ServiceResponse<List<FuncionarioModel>> DeleteFuncionario(int id);
    ServiceResponse<List<FuncionarioModel>> InativaFuncionario(int id);

}
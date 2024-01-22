using ASPNET_CORE_WEBAPI_CRUD.DataContext;
using ASPNET_CORE_WEBAPI_CRUD.Models;

namespace ASPNET_CORE_WEBAPI_CRUD.Services.FuncionarioService;

public class FuncionarioService : IFuncionarioService
{
    private readonly AppDbContext _db;
    public FuncionarioService(AppDbContext db)
    {
        _db = db;
    }
    public ServiceResponse<List<FuncionarioModel>> CreateFuncionario(FuncionarioModel funcionario)
    {
        ServiceResponse<List<FuncionarioModel>> serviceResponse = new ServiceResponse<List<FuncionarioModel>>();

        try
        {
            _db.Funcionarios.Add(funcionario);
            _db.SaveChanges();

            serviceResponse.Dados = _db.Funcionarios.ToList();

        }
        catch (Exception ex)
        {
            serviceResponse.Mensagem = ex.Message;
            serviceResponse.Sucesso = false;
        }

        return serviceResponse;
    }

    public ServiceResponse<List<FuncionarioModel>> DeleteFuncionario(int id)
    {
        ServiceResponse<List<FuncionarioModel>> serviceResponse = new ServiceResponse<List<FuncionarioModel>>();

        try
        {
            var funcionario = _db.Funcionarios.FirstOrDefault(q => q.Id == id);

            if (funcionario != null)
            {
                _db.Funcionarios.Remove(funcionario);
                _db.SaveChanges();
            }

            serviceResponse.Dados = _db.Funcionarios.ToList();

        }
        catch (Exception ex)
        {
            serviceResponse.Mensagem = ex.Message;
            serviceResponse.Sucesso = false;
        }

        return serviceResponse;
    }

    public ServiceResponse<FuncionarioModel> GetFuncionarioById(int id)
    {
        ServiceResponse<FuncionarioModel> serviceResponse = new ServiceResponse<FuncionarioModel>();

        try
        {
            serviceResponse.Dados = _db.Funcionarios.FirstOrDefault(q => q.Id == id);
        }
        catch (Exception ex)
        {
            serviceResponse.Mensagem = ex.Message;
            serviceResponse.Sucesso = false;
        }

        return serviceResponse;
    }

    public ServiceResponse<List<FuncionarioModel>> GetFuncionarios()
    {
        ServiceResponse<List<FuncionarioModel>> serviceResponse = new ServiceResponse<List<FuncionarioModel>>();

        try
        {
            serviceResponse.Dados = _db.Funcionarios.ToList();
        }
        catch (Exception ex)
        {
            serviceResponse.Mensagem = ex.Message;
            serviceResponse.Sucesso = false;
        }

        return serviceResponse;
    }

    public ServiceResponse<List<FuncionarioModel>> InativaFuncionario(int id)
    {
        ServiceResponse<List<FuncionarioModel>> serviceResponse = new ServiceResponse<List<FuncionarioModel>>();

        try
        {
            var funcionario = _db.Funcionarios.FirstOrDefault(q => q.Id == id);

            if (funcionario != null)
            {
                funcionario.Ativo = false;
                _db.Funcionarios.Update(funcionario);
                _db.SaveChanges();
            }

            serviceResponse.Dados = _db.Funcionarios.ToList();

        }
        catch (Exception ex)
        {
            serviceResponse.Mensagem = ex.Message;
            serviceResponse.Sucesso = false;
        }

        return serviceResponse;
    }

    public ServiceResponse<List<FuncionarioModel>> UpdateFuncionario(FuncionarioModel funcionario)
    {
        ServiceResponse<List<FuncionarioModel>> serviceResponse = new ServiceResponse<List<FuncionarioModel>>();

        try
        {
            if (funcionario != null)
            {
                _db.Funcionarios.Update(funcionario);
                _db.SaveChanges();
            }

            serviceResponse.Dados = _db.Funcionarios.ToList();

        }
        catch (Exception ex)
        {
            serviceResponse.Mensagem = ex.Message;
            serviceResponse.Sucesso = false;
        }

        return serviceResponse;
    }
}
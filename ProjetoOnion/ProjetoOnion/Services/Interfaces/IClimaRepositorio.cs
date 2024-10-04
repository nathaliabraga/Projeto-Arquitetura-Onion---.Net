using ProjetoOnion.Applications.Models;

namespace ProjetoOnion.Services.Interfaces
{
    public interface IClimaRepositorio
    {
        Task<List<ClimaModel>> BuscarTodosClimas();
        Task<ClimaModel> BuscarPorID(int id);
        Task<ClimaModel> Adicionar(ClimaModel clima);
        Task<ClimaModel> Atualizar(ClimaModel clima, int id);
        Task<bool> Apagar(int id);
    }
}

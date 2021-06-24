using App.RefitConsumer.Model;
using Refit;
using System.Threading.Tasks;

namespace App.RefitConsumer.Business.Interface
{
    public interface IStudentService
    {
        [Get("/Aluno/busca-cpf/?cpf={cpf}")]
        Task<StudentResponse> GetStudentByCpfAsync(string cpf);
    }
}

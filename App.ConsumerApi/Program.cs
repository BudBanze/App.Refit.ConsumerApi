using App.RefitConsumer.Business.Interface;
using Refit;
using System;
using System.Threading.Tasks;

namespace App.RefitConsumer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var studentClient = RestService.For<IStudentService>("https://localhost:44359");
                Console.WriteLine("Informe o CPF do aluno: ");
                string cpfStudent = Console.ReadLine().ToString();

                Console.WriteLine($"Consultando o CPF {cpfStudent} na lista de alunos cadastrados");

                var student = await studentClient.GetStudentByCpfAsync(cpfStudent);

                Console.Write($"\nNome: {student.Nome}, \nCpf: {student.Cpf}, \nEndereco: {student.Endereco}, \nId: {student.Id}, \nAtivo: {student.Ativo}");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro na consulta de cep: {e.Message}");
            }
        }
    }
}

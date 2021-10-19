using System;
using CadastroEmpresaExercicioUdemy.Entities;
using CadastroEmpresaExercicioUdemy.Entities.Enums;

namespace CadastroEmpresaExercicioUdemy
{
    class Program
    {
        static void Main(string[] args)
        {

            Empresa empresa = new Empresa
            {
                Id = 1,
                Name = "Teste",
                InicioEmpresa = DateTime.Now,
                Status = EmpresaStatus.Ativo
            };

            Console.WriteLine(empresa);


        }
    }
}

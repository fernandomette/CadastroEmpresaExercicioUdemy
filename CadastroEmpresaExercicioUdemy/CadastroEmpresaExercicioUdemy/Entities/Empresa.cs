using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroEmpresaExercicioUdemy.Entities.Enums;

namespace CadastroEmpresaExercicioUdemy.Entities
{
    class Empresa
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime InicioEmpresa { get; set; }

        public EmpresaStatus Status { get; set; }

        public override string ToString()
        {
            return ($"Id:{Id}, Name:{Name}, Status:{Status}");
        }

    }
}

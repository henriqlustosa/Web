using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web
{
    public class Relatorio : IRelatorio
    {
        private readonly IListaDePacientes pacientes;

        public Relatorio(IListaDePacientes pacientes)
        {
            this.pacientes = pacientes;
        }
        public async         Task
Imprimir(HttpContext context)
        {
          
                // Criar um foreach para vários Pacientes

                await context.Response.WriteAsync($"{pacientes.GetPacientes().Nm_nome,-40},{pacientes.GetPacientes().Cd_prontuario,-10},{pacientes.GetPacientes().In_sexo,5}");



        }
    }
}

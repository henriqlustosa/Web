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

            foreach (Paciente paciente in pacientes.GetPacientes())
            {

                await context.Response.WriteAsync($"{paciente.Nm_nome,-40},{paciente.Cd_prontuario,-10},{paciente.In_sexo,5}\r\n");

            }

        }
    }
}

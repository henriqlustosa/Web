using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web
{
    public class Censo
    {

        public String cd_prontuario { get; set; }
        public String nm_paciente { get; set; }
        public String dt_nascimento { get; set; }
        public String nr_quarto { get; set; }
        public String dt_internacao_data { get; set; }
        public String dt_internacao_hora { get; set; }
        public String nm_especialidade { get; set; }
        public String nm_medico { get; set; }
        public String dt_ultimo_evento_data { get; set; }
        public String dt_ultimo_evento_hora { get; set; }
        public String nm_origem { get; set; }
        public String nr_convenio { get; set; }
        public String in_sexo { get; set; }
        public int nr_idade { get; set; }
        public String cod_CID { get; set; }
        public String descricaoCID { get; set; }
        public String nm_unidade_funcional { get; set; }
        public String tempo { get; set; }
        public String vinculo { get; set; }
    }
}

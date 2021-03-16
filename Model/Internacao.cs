using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web
{
    public class Internacao
    {

        public string Cd_prontuario { get; set; }
        public string Nm_paciente { get; set; }
        public string In_sexo { get; set; }
        public string Nr_idade { get; set; }
        public string Nr_quarto { get; set; }
        public string Nr_leito { get; set; }
        public string Nm_ala { get; set; }
        public string Nm_clinica { get; set; }
        public string Nm_unidade_funcional { get; set; }
        public string Nm_acomodacao { get; set; }
        public string St_leito { get; set; }
        public string Dt_internacao { get; set; }
        public string Dt_entrada_setor { get; set; }
        public string Nm_especialidade { get; set; }
        public string Nm_medico { get; set; }
        public string Dt_ultimo_evento { get; set; }
        public string Nm_origem { get; set; }
        public string Sg_cid { get; set; }
        public string Tx_observacao { get; set; }
        public string Nr_convenio { get; set; }
        public string Nr_plano { get; set; }
        public string Nm_convenio_plano { get; set; }
        public string Nr_crm_profissional { get; set; }
        public string Nm_carater_internacao { get; set; }
        public string Nm_origem_internacao { get; set; }
        public string Nr_procedimento { get; set; }
        public string Dt_alta_medica { get; set; }
        public string Dt_saida_paciente { get; set; }
        public string Dc_tipo_alta_medica { get; set; }
    }
}

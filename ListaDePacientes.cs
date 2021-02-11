using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace web
{
    public class ListaDePacientes : IListaDePacientes
    {

        public List<Paciente> GetPacientes()
        {

            // Criar um foreach para vários pacientes.

            int[] cd_prontuario = new int[50];
            cd_prontuario[0] = 2642;
            cd_prontuario[1] = 44354;
            cd_prontuario[2] = 11179926;
            cd_prontuario[3] = 10931582;
            cd_prontuario[4] = 11556008;
            cd_prontuario[5] = 11042041;
            cd_prontuario[6] = 11165834;
            cd_prontuario[7] = 11485018;
            cd_prontuario[8] = 11113925;
            cd_prontuario[10] = 688184;
            cd_prontuario[11] = 135335;
            cd_prontuario[12] = 195347;
            cd_prontuario[13] = 115899;
            cd_prontuario[14] = 11129186;
            cd_prontuario[15] = 270512;
            cd_prontuario[16] = 757872;
            cd_prontuario[17] = 4570784;
            cd_prontuario[18] = 2572725;
            cd_prontuario[19] = 3657384;
            cd_prontuario[20] = 12083184;
            cd_prontuario[21] = 2786663;
            cd_prontuario[22] = 10802346;
            cd_prontuario[23] = 2572733;
            cd_prontuario[24] = 10199578;
            cd_prontuario[25] = 10842177;
            cd_prontuario[26] = 11136710;
            cd_prontuario[27] = 423327;
            cd_prontuario[28] = 11089885;
            cd_prontuario[29] = 11605482;
            cd_prontuario[30] = 11390887;
            cd_prontuario[31] = 10737492;
            cd_prontuario[32] = 10809622;
            cd_prontuario[33] = 11034568;
            cd_prontuario[34] = 10962330;
            cd_prontuario[35] = 11610334;
            cd_prontuario[36] = 11609518;
            cd_prontuario[37] = 10884203;
            cd_prontuario[38] = 11329182;
            cd_prontuario[39] = 11049731;
            cd_prontuario[40] = 11147717;
            cd_prontuario[41] = 10819779;
            cd_prontuario[42] = 4972857;
            cd_prontuario[43] = 11255270;
            cd_prontuario[44] = 11291457;
            cd_prontuario[45] = 5212568;
            cd_prontuario[46] = 11391224;
            cd_prontuario[47] = 5274816;
            cd_prontuario[48] = 10782076;
            cd_prontuario[49] = 765909;









            Paciente paciente = null;


            List<Paciente> pacientes = new List<Paciente>();


            foreach (int pront in cd_prontuario)
            {

                try
                {

                    string URI = "http://intranethspm:5003/hspmsgh-api/pacientes/paciente/" + pront.ToString();
                    WebRequest request = WebRequest.Create(URI);

                    HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(URI);
                    // Sends the HttpWebRequest and waits for a response.
                    HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();

                    if (httpResponse.StatusCode == HttpStatusCode.OK)
                    {
                        var reader = new StreamReader(httpResponse.GetResponseStream());

                        JsonSerializer json = new JsonSerializer();

                        var objText = reader.ReadToEnd();

                        paciente = JsonConvert.DeserializeObject<Paciente>(objText);

                        pacientes.Add(paciente);



                        // GridInternado.DataSource = details; // apresentação dos dados da lista
                        //  GridInternado.DataBind();
                    }


                }

                catch (WebException ex)
                {
                    string err = ex.Message;

                }
            }

            return (List<Paciente>) pacientes.OrderBy(x => x.Nm_nome).Where( x => x.Nm_nome != null).ToList();
        } 
    }
}

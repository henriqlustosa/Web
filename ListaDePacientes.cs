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

        public Paciente GetPacientes()
        {

            // Criar um foreach para vários pacientes.

            Paciente paciente = null;
            try
            {

                string URI = "http://intranethspm:5003/hspmsgh-api/pacientes/paciente/11209913";
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





                    // GridInternado.DataSource = details; // apresentação dos dados da lista
                    //  GridInternado.DataBind();
                }


            }

            catch (WebException ex)
            {
                string err = ex.Message;
            }

            return paciente;
        } 
    }
}

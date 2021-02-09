using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace web
{
    public class Startup
    {

       
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            Paciente details = null;
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
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

                  details = JsonConvert.DeserializeObject<Paciente>(objText);


            


                    // GridInternado.DataSource = details; // apresentação dos dados da lista
                    //  GridInternado.DataBind();
                }


            }

            catch (WebException ex)
            {
                string err = ex.Message;
            }
            app.Run(async (context) =>
            {

                await context.Response.WriteAsync( $"{details.Cd_prontuario, -10}{details.Nm_nome, -40}{details.Email}{details.In_sexo, 5}");
            });
        }
    }
}

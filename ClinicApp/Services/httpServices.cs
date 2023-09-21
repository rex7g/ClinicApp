using ClinicApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClinicApp.Services
{
    public class httpServices:IHttpService
    {
        readonly HttpClient client;
        readonly JsonSerializerOptions serializerOptions;


        public httpServices()
        {
            client = new HttpClient();
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }
        public async Task<IEnumerable<CitasMedicas>> GetCitasMedicas()
        {

            try
            {
                Uri uri = new(string.Format($"{Constants.API_BASE_ADDRESS}api/CitaMedica/ListaCitasMedicas"));

                HttpResponseMessage response = await client.GetAsync(uri);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IEnumerable<CitasMedicas>>(jsonString);
                }
                else
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IEnumerable<CitasMedicas>>(jsonString);
                }
               
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }


        }
        public async Task<Usuario> GetUsuario(string usuario)
        {

            try
            {
                Uri uri = new(string.Format($"{Constants.API_BASE_ADDRESS}/api/CitaMedica/BuscarUsuarioporNombre/{usuario}"));

                HttpResponseMessage response = await client.GetAsync(uri);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Usuario>(jsonString);
                }
                else
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Usuario>(jsonString);
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }


        }
        //public async Task<Usuario> GetPasword(string pasword)
        //{

        //}



    }
}

using AppDragonBallZ.Model;
using AppDragonBallZ.Model.DBZmodel;
using AppDragonBallZ.RepositoryPattern.IRepositoryPattern;
using AppDragonBallZ.Generico;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDragonBallZ.RepositoryPattern
{
    public class CharactersRepository : ICharactersRepository
    {
        public async Task<Respuesta> Characters(string uriApi)
        {
            Respuesta respuesta = new();
            try
            {                
                string urlApi = uriApi;

                var httpClient = new HttpClient();
                Pagination pagination = new();

                var response = await httpClient.GetAsync(urlApi);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<Pagination>(content);
                    pagination = result;
                }

                respuesta.Data = pagination;
                respuesta.Resultado = true;
                respuesta.Mensaje = "Consulta exitosa";
               
            }
            catch (Exception ex)
            {
                respuesta.Resultado = false;
                respuesta.Mensaje = "Error en método: Characters - > " + ex.Message.ToString();
            }

            return respuesta;
        }

        public async Task<Respuesta> GetCharacterById(long characterId)
        {
            Respuesta respuesta = new();
            try
            {
                string urlApi = $"{Utilidades.UrlApiDBZ}/{characterId}";

                var httpClient = new HttpClient();
                Character character = new();

                var response = await httpClient.GetAsync(urlApi);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<Character>(content);
                    character = result;
                }

                respuesta.Data = character;
                respuesta.Resultado = true;
                respuesta.Mensaje = "Consulta exitosa";

            }
            catch (Exception ex)
            {
                respuesta.Resultado = false;
                respuesta.Mensaje = "Error en método: GetCharacterById - > " + ex.Message.ToString();
            }

            return respuesta;
        }

        public Task<Respuesta> GetCharacterByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}

using IuPeliculas.Interface;
using IuPeliculas.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IuPeliculas.Repository
{
    public class MoviesRepository : IMoviesRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string urlApi;
        private readonly string apikey;
        public MoviesRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            urlApi = _configuration["AppConfig:urlApi"].ToString();
            apikey = _configuration["AppConfig:apikey"].ToString();
        }

        /// <summary>
        /// Función que permite consultar las peliculas según los parametros de busqueda
        /// </summary>
        /// <param name="search">termino de busqueda en el api que se consume</param>
        /// <param name="type">termino de tipo de busqueda en el api que se consume</param>
        /// <returns>Objeto tipo searchResult</returns>

        public async Task<searchResult> GetMovieSearch(string search,string type)
        {
            try
            {
                searchResult objResult = new searchResult();
                StringBuilder urlStr = new StringBuilder();
                urlStr.AppendFormat("s={0}&type={1}&apikey={2}", search, type,apikey);
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(urlApi + urlStr);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(urlApi + urlStr);
                    if (response.IsSuccessStatusCode)
                    {                       
                        var jsonString = response.Content.ReadAsStringAsync().Result;
                        objResult = JsonConvert.DeserializeObject<searchResult>(jsonString);
                    }                  
                }
                return objResult;
            }            
            catch (Exception e)
            {
                string rerr = e.Message.ToString();
                throw e;
            }
        }


        /// <summary>
        /// Función que permite consultar las peliculas por Id
        /// </summary>
        /// <param name="search">id del objeto seleccionado que el api que se consume</param>
        /// <returns>Objeto tipo Movies</returns>

        public async Task<Movies> GetMovieByID(string id)
        {
            try
            {
                Movies objResult = new Movies();
                StringBuilder urlStr = new StringBuilder();
                urlStr.AppendFormat("i={0}&plot=full&apikey={1}", id, apikey);
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(urlApi + urlStr);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(urlApi + urlStr);
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = response.Content.ReadAsStringAsync().Result;
                        objResult = JsonConvert.DeserializeObject<Movies>(jsonString);
                    }
                }
                return objResult;
            }
            catch (Exception e)
            {
                string rerr = e.Message.ToString();
                throw e;
            }
        }
    }
}

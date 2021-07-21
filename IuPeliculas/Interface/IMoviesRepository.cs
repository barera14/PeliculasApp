using IuPeliculas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IuPeliculas.Interface
{
    public interface IMoviesRepository
    {

        /// <summary>
        /// Función que permite consultar las peliculas según los parametros de busqueda
        /// </summary>
        /// <param name="search">termino de busqueda en el api que se consume</param>
        /// <param name="type">termino de tipo de busqueda en el api que se consume</param>
        /// <returns>Objeto tipo searchResult</returns>
        Task<searchResult> GetMovieSearch(string search, string type);

        /// <summary>
        /// Función que permite consultar las peliculas por Id
        /// </summary>
        /// <param name="search">id del objeto seleccionado que el api que se consume</param>
        /// <returns>Objeto tipo Movies</returns>
        Task<Movies> GetMovieByID(string Id);
        
    }
}

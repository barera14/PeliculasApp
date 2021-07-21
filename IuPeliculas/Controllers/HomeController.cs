using IuPeliculas.Interface;
using IuPeliculas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IuPeliculas.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMoviesRepository _moviesRepository;

        public HomeController(IMoviesRepository moviesRepository)
        {
            _moviesRepository = moviesRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ListMovies(string id,string name)
        {
            searchResult objResult = new searchResult();
            objResult = await _moviesRepository.GetMovieSearch(id, name);            
            return PartialView("ListMovies", objResult);
                        
        }

        public async Task<IActionResult> Detalle(string id)
        {
            Movies objResult = new Movies();
            objResult = await _moviesRepository.GetMovieByID(id);
            return View(objResult);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

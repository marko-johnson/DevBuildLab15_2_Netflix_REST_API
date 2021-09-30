using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Netflix_REST_API.Models;

namespace Netflix_REST_API.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
 // 1. Get a list of all movies --- https://localhost:44341/api/movies/allmovietitles

        [HttpGet("allmovietitles")]  
        public List<Movies> readall()
        {
            return DAL.ReadAllMovies();
        }

// 2. Get a list of all movies in a specific category --- https://localhost:44341/api/movies/category?cat=Comedy --- https://localhost:44341/api/movies/category?cat=Romance%2FDrama
//     o User specifies category as a query parameter --- https://localhost:44341/api/movies/category?cat=Horror --- https://localhost:44341/api/movies/category?cat=Crime%2FRomance
//                                                        https://localhost:44341/api/movies/category?cat=Action%2FAdventure --- https://localhost:44341/api/movies/category?cat=Thriller%2FAdventure
        [HttpGet("category")]                   
        public List<Movies> readbycategory(string cat)
        {
            List<Movies> result = DAL.ReadByCategory(cat);
            return result;
        }
        

// 6. Get a list of all movie categories --- https://localhost:44341/api/movies/listofcategories

        [HttpGet("listofcategories")] 
        public List<Movies> readallcategories()
        {
            return DAL.ReadAllCategories();
        }


// 7. Get info about a specific movie       --- https://localhost:44341/api/movies/movietitle?title=Candyman --- https://localhost:44341/api/movies/movietitle?title=Is%20This%20The%20End
//      o User specifies title as a query parameter

        [HttpGet("movietitle")]     
        public List<Movies> readbytitle(string title)
        {
            List<Movies> result = DAL.ReadMovieInfoByTitle(title);
            return result;
        }


// 8. Get a list of movies which have a keyword in their title --- https://localhost:44341/api/movies/titlekeyword?keyword=een --- https://localhost:44341/api/movies/titlekeyword?keyword=man
//      o User specifies title as a query parameter

        [HttpGet("titlekeyword")] 
        public List<Movies> readbykeyword(string keyword)
        {
            List<Movies> result = DAL.ReadMovieInfoByKeyword(keyword);
            return result;
        }

// Add
        [HttpPut("add")]  // https://localhost:44341/api/movies/add
        public Movies addMovie(Movies mov)
        {
            return DAL.AddMovie(mov);
        }

// Delete

        [HttpDelete("delete")]  // https://localhost:44341/api/movies/delete?id=12
        public bool deleteMovie(int id)
        {
            return DAL.DeleteMovie(id);
        }

// Update
        [HttpPut("update")]        // https://localhost:44341/api/movies/update
        public Movies UpdateMovie(Movies mov)
        {
            return DAL.UpdateMovie(mov);
        }
    }
}



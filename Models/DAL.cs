using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using Dapper;

namespace Netflix_REST_API.Models
{
    public class DAL
    {
        public static MySqlConnection DB;

        public static List<Movies> ReadAllMovies()
        {
            return DB.GetAll<Movies>().ToList();
        }

        public static List<Movies> ReadByCategory(string cat)
        {
            var myparams = new { thecat = cat };
            string sql = "select * from movies where category = @thecat";

            List<Movies> movie = DB.Query<Movies>(sql, myparams).ToList();
            return movie;
        }

        public static List<Movies> ReadAllCategories()
        {
            string sql = "select category from movies";
            List<Movies> movie = DB.Query<Movies>(sql).ToList();
            return movie;
        }

        public static List<Movies> ReadMovieInfoByTitle(string title)
        {
            var myparams = new { thetitle = title };
            string sql = "select * from movies where title = @thetitle";
            List<Movies> movie = DB.Query<Movies>(sql, myparams).ToList();
            return movie;
        }

        public static List<Movies> ReadMovieInfoByKeyword(string keyword)
        {
            var myparams = new { thekeyword = "%"+ keyword + "%" };
            string sql = "select * from movies where title like @thekeyword";  // "select * from movies where title like %@thekeyword%";
            List<Movies> movie = DB.Query<Movies>(sql, myparams).ToList();
            return movie;
        }

        public static Movies AddMovie(Movies mov)
        {
            DB.Insert<Movies>(mov);
            return mov;
        }

        public static bool DeleteMovie(int id)
        {
            Movies movie = new Movies() { id = id };
            DB.Delete<Movies>(movie);
            return true;
        }

        public static Movies UpdateMovie(Movies mov)
        {
            DB.Update<Movies>(mov);
            return mov;
        }
    }
}

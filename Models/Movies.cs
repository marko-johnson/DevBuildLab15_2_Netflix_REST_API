using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Netflix_REST_API.Models
{
    [Table("movies")]
    public class Movies
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string category { get; set; }
    }
}

using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinProject.Models
{
    public class Anime
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Studio { get; set; }
    }
}

using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileAppGroup4.SQLite
{
    [Table("Users")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Year { get; set; }
        public int Mounth { get; set; }
        public string Recommend { get; set; }
        public string PhotoPath { get; set; }

        [Unique]
        public string UserName { get; set; }
        public string Password { get; set; }

        public int IdUser { get; set; }
    }
}

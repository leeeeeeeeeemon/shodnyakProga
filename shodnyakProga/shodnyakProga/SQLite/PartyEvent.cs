using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shodnyak.SQLite
{
    [Table("PartyEvent")]
    public class PartyEvent
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; } 
        public DateTime Date { get; set; }
        public string PhotoPath { get; set; }
        public string Description { get; set; }
    }
}

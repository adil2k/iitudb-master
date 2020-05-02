using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iitu_db.Models
{
    public class Competition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String Author { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public List<TeamCompetition> TeamCompetitions { get; set; }
    }
}

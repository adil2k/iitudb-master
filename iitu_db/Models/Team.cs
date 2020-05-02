using System;
using System.Collections.Generic;

namespace iitu_db.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Budget { get; set; }

        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }

        public List<TeamCompetition> TeamCompetitions { get; set; }

        public List<Player> Player { get; set; }
    }
}

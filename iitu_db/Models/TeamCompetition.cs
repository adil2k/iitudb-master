using System;
namespace iitu_db.Models
{
    public class TeamCompetition
    {
        public int TeamId { get; set; }
        public Team Team { get; set; }

        public int CompetitionId { get; set; }
        public Competition Competition { get; set; }

    }
}

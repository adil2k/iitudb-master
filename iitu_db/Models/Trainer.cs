using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace iitu_db.Models
{
    public class Trainer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [Remote("NameExists", HttpMethod = "POST", ErrorMessage = "Name already registered.")]
        public string Name { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public int WorkExperience { get; set; }

        public Team Team { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iitu_db.Models
{                           //2
    public class Player : IValidatableObject
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public String Position { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Name.Length > 10)
            {
                yield return new ValidationResult("Name cannot be large in length than 10");
            }
        }
    }
}

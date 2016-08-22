﻿using System;
using System.ComponentModel.DataAnnotations;
using WebApplication2.Models;

namespace GigHub.Models
{
    public class Gig
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser Artists { get; set; }
            
        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        [Required]
        public Genre Genre { get; set;  }

    }
    
}

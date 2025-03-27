﻿using System.ComponentModel.DataAnnotations;

namespace InteractiveMap.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public string ProfilePicture { get; set; }  // URL or base64

        public string Bio { get; set; }
    }
}

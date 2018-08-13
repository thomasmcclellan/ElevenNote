﻿using System.ComponentModel.DataAnnotations;

namespace ElevenNote.WebMVC.Models
{
    public class NoteCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field")]
        public string Title { get; set; }

        [MaxLength(8000)]
        public string Content { get; set; }

        public override string ToString() => Title;
        
    }
}
﻿using System.ComponentModel.DataAnnotations;

namespace TimeTracker.Domain
{
    public class Project: BaseEntity
    {
        [Required]
        [MinLength(1)]
        public string Title { get; set; } = string.Empty;
    }
}

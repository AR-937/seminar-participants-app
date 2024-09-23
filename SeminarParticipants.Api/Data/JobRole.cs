﻿using System.ComponentModel.DataAnnotations;

namespace SeminarParticipants.Api.Data
{
    public class JobRole : BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; } = null!;
    }
}
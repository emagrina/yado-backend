﻿using System.ComponentModel.DataAnnotations;
namespace yado_backend.Models.Dtos
{
    public class PopulationDto
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public required string Name { get; set; }
    }
}
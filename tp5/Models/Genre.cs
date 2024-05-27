﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tp5.Models
{
    public class Genre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public byte Id { get; set; }

        [MaxLength(100)]

        public string Name { get; set; }
    }
}
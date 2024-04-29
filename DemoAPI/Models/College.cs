﻿using System.ComponentModel.DataAnnotations;

namespace DemoAPI.Models
{
    public class College
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}

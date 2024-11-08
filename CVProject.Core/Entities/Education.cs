﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Core.Entities
{
    public class Education : IEntity
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        
        [StringLength(500)]
        public string? Degree { get; set; }
        
        [StringLength(500)]
        public string? Institution { get; set; }
        
        [StringLength(50)]
        public string? Grade { get; set; }

        [StringLength(50)]
        public string? Period { get; set; }
        public Person Person { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
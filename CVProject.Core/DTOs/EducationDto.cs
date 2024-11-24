using CVProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Core.DTOs
{
    public class EducationDto
    {
        public string? Degree { get; set; }
        public string? Institution { get; set; }
        public string? Grade { get; set; }
        public string? Period { get; set; }
    }
}

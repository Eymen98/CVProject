using CVProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Core.DTOs
{
    public class ExperienceDto
    {
        public int Id { get; set; }
        public int? PersonId { get; set; }
        public string? Position { get; set; }
        public string? Company { get; set; }
        public string? Description { get; set; }
        public string? EmploymentDuration { get; set; }
       
    }
}

using CVProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Core.DTOs
{
    public class ProjectDto
    {
        public string? ProjectName { get; set; }
        public string? Description { get; set; }
        public string? period { get; set; }
    }
}

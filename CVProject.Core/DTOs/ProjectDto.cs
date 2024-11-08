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
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string? ProjectName { get; set; }
        public string? Description { get; set; }
        public string? period { get; set; }
        public Person Person { get; set; }
    }
}

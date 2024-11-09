using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Core.DTOs
{
    public class SkillDto
    {
        public int Id { get; set; }
        public int? PersonId { get; set; }
        public string? SkillName { get; set; }
        public string? SkillValue { get; set; }
    }
}

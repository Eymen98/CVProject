using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Core.DTOs
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string? JobTitle { get; set; }

    }
}

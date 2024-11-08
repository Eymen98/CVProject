using CVProject.Core.Entities;
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
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? LinkedInProfile { get; set; }
        public string? GithubProfile { get; set; }
        public string? Summary { get; set; }
        public string? ImageUrl { get; set; }
        public string? CvUrl { get; set; }
        public string? InstagramProfile { get; set; }
        public string? XProfile { get; set; }
        
    }
}

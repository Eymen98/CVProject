using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Core.Entities
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? JobTitle { get; set; }
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? DrivingLicense { get; set; }
        public int? MaritalStatus { get; set; }  //Single, Married, Divorced
        public string? WebsiteUrl { get; set; }
        public string? LinkedInProfile { get; set; }
        public string? GithubProfile { get; set; }
        public string? Summary { get; set; }
        public string? ImageUrl { get; set; }
        public string? CvUrl { get; set; }
        public string? XProfile { get; set; }
        public string? InstagramProfile { get; set; }
    }
}

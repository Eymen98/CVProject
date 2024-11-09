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
       
        [StringLength(100)]
        public string? JobTitle { get; set; }

        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(100)]
        public string? SurName { get; set; }
        
        [StringLength(100)]
        public string? Email { get; set; }

        [StringLength(100)]
        public string? PhoneNumber { get; set; }

        [StringLength(500)]
        public string? Address { get; set; }
        
        [StringLength(10)]
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
        public virtual ICollection<Experience>? Experiences { get; set; }
        public virtual ICollection<Education>? Educations { get; set; }
        public virtual ICollection<Project>? Projects { get; set; }
        public virtual ICollection<Skill>? Skills { get; set; }
        public virtual ICollection<Language>? Languages { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Core.Entities
{
    public class Skill : IEntity
    {
        public int Id { get; set ; }
        
        [ForeignKey("Person")]
        public int? PersonId { get; set ; }
        
        [StringLength(100)]
        public string? SkillName { get; set ; }
        public string? SkillValue { get; set; }
        public virtual Person? Person { get; set; }
        public DateTime CreatedDate { get ; set ; }
        public DateTime? UpdatedDate { get ; set ; }
    }
}

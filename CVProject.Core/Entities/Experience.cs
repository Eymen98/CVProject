using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Core.Entities
{
    public class Experience : IEntity
    {
        public int Id { get ; set; }

        [ForeignKey("Person")]
        public int? PersonId { get; set; }
        
        [StringLength(100)]
        public string? Position { get ; set ; }
        
        [StringLength(100)]
        public string? Company { get; set; }
        public string? Description { get; set; }
        
        [StringLength(50)]
        public string? EmploymentDuration { get; set; }
        public virtual Person? Person { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }



    }
}

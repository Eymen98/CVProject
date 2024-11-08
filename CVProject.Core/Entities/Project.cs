using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Core.Entities
{
    public class Project : IEntity
    {
        public int Id { get ; set ; }
        
        [ForeignKey("Person")]
        public int? PersonId { get ; set ; }
        
        [StringLength(200)]
        public string? ProjectName { get ; set ; }
        public string? Description { get ; set ; }
        
        [StringLength(50)]
        public string? period {  get ; set ; }
        public virtual  Person? Person { get ; set ; }
        public DateTime CreatedDate { get ; set ; }
        public DateTime? UpdatedDate { get ; set ; }
    }
}

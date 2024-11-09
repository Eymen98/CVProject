using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Core.Entities
{
    public class Language : IEntity
    {
        public int Id { get ; set ; }
        [ForeignKey("Person")]
        public int? PersonId { get; set; }

        [StringLength(50)]
        public string? LanguageName { get; set; }
        public string? LanguageValue { get; set; }
        public virtual Person? Person { get; set; }
        public DateTime CreatedDate { get ; set ; }
        public DateTime? UpdatedDate { get ; set ; }
    }
}

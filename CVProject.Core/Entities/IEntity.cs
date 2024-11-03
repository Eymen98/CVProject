using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Core.Entities
{
    public interface IEntity
    {
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        int Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime? UpdatedDate { get; set; }
    }
}

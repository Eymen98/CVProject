using CVProject.Core.Entities;
using CVProject.Core.Interfaces.Repository;
using CVProject.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Infrastructure.Repository
{
    public class PersonSkillRepository : Repository<Skill>, IPersonSkillRepository
    {
        public PersonSkillRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

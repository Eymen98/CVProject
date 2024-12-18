﻿using CVProject.Core.Entities;
using CVProject.Core.Interfaces.Repository;
using CVProject.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Infrastructure.Repository
{
    public class PersonLanguageRepository : Repository<Language>, IPersonLanguageRepository
    {
        public PersonLanguageRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

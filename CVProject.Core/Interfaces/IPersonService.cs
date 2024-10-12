using CVProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Core.Interfaces
{
    public interface IPersonService
    {
        public Person GetPerson(int id);

        public int CreatePerson(Person person);
        
    }
}

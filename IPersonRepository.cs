using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entites;

namespace Aplication.Interfaces
{
    internal interface IPersonRepository:IRepository<Person>
    {
        public List<CustomField<string>> GetCustomFields();
    }
}

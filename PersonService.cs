using Aplication.Dtos;
using Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Services
{
    internal class PersonService
    {
        private readonly IPersonRepository _personRepository;  
        public PersonService(IPersonRepository personRepository) {
            _personRepository = personRepository;
        }
        public PersonGetByIdResponse GetById(Guid id)
        {
            var person = _personRepository.GetByID(id);
            //TODO: AutoMapper
            throw new NotImplementedException();
        }
    }
}

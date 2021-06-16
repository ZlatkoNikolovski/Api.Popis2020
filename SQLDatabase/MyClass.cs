using Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDatabase
{
    public class MyClass
    {
        private readonly IGenericRepository<string> _genericRepository;
        public MyClass(IGenericRepository<string> genericRepository)
        {
            _genericRepository = genericRepository;            
        }

        private void testMethod()
        { 
            _genericRepository.GetAll();
        }
    }
}

using Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDatabase
{
    public class MyClassB
    {
        private readonly IGenericRepository<string> _genericRepository;
        public MyClassB(IGenericRepository<string> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        private void TestMethod()
        {
            
            _genericRepository.GetAll();
        }
    }
}

using Entities;
using IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{

        public class SampleDBRepository : ISampleRepository
        {
            public SampleData GetData()
            {
                return new SampleData
                {
                    SampleProperty = "Hello World from DataBase"
                };
            }
        }
    
}

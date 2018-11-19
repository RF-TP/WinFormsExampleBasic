using Entities;
using IRepositories;

namespace Repositories
{
    public class SampleRepository : ISampleRepository
    {
        public SampleData GetData()
        {
            return new SampleData
                        {
                            SampleProperty = "Hello World from File"
                        };
        }
    }
}

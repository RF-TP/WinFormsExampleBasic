using Entities;
using IRepositories;
using IServices;

namespace Servises
{
    public class SampleService : ISampleService
    {
        private ISampleRepository _sampleRepository;

        public SampleService(ISampleRepository sampleRepository)
        {
            _sampleRepository = sampleRepository;
        }

        public SampleData GetData()
        {
            return _sampleRepository.GetData();
        }
    }
}

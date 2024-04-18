using NASA_gestionale_task.Models;
using NASA_gestionale_task.Repositories;

namespace NASA_gestionale_task.Services
{
    public class OggettoCelesteService : IService<OggettoCeleste>
    {

        private readonly OggettoCelesteRepo _repository;

        public OggettoCelesteService(OggettoCelesteRepo repository)
        {
            _repository = repository;
        }

        public IEnumerable<OggettoCeleste> PrendiliTutti()
        {
            return _repository.GetAll();
        }


    }
        
}

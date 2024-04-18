using NASA_gestionale_task.Models;
using NASA_gestionale_task.Repositories;

namespace NASA_gestionale_task.Services
{
    public class SistemaService : IService<Sistema>
    {
       

        private readonly SistemaRepo _repository;

        public SistemaService(SistemaRepo repository)
        {
            _repository = repository;
        }

        public IEnumerable<Sistema> PrendiliTutti()
        {
            return _repository.GetAll();
        }


    }
}

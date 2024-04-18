using NASA_gestionale_task.Models;

namespace NASA_gestionale_task.Repositories
{
    public class OggettoCelesteSistemaRepo : IRepo<OggettoCelesteSistema>
    {
        private readonly NasaContext _context;

        public OggettoCelesteSistemaRepo(NasaContext context)
        {
            _context = context;
        }



        public bool Create(OggettoCelesteSistema entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public OggettoCelesteSistema? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OggettoCelesteSistema> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(OggettoCelesteSistema entity)
        {
            throw new NotImplementedException();
        }
    }
}

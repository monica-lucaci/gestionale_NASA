using NASA_gestionale_task.Models;

namespace NASA_gestionale_task.Repositories
{
    public class OggettoCelesteRepo : IRepo<OggettoCeleste>
    {
        private readonly NasaContext _context;

        public OggettoCelesteRepo(NasaContext context)
        {
            _context = context;
        }

        public bool Create(OggettoCeleste entity)
        {
            try
            {
                _context.OggettiCelesti.Add(entity);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                OggettoCeleste? temp = Get(id);
                if (temp != null)
                {
                    _context.OggettiCelesti.Remove(temp);
                    _context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            return false;
        }

        public OggettoCeleste? Get(int id)
        {
            return _context.OggettiCelesti.Find(id);
        }

        public IEnumerable<OggettoCeleste> GetAll()
        {
            return _context.OggettiCelesti.ToList();
        }

        public bool Update(OggettoCeleste entity)
        {
            try
            {
                _context.OggettiCelesti.Update(entity);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public OggettoCeleste? GetByCodice(string codice)
        {
            try
            {
                return _context.OggettiCelesti.FirstOrDefault(p => p.Codice == codice);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }


        //public List<OggettoCeleste> GetByAllFields(string query)
        //{
        //    return _context.OggettiCelesti.Where(p =>
        //        (p.Nome != null && p.Nome.Contains($"{query}")) ||
        //        (p.Tipologia != null && p.Tipologia.Contains($"{query}"))
        //        ).ToList();
        //}

    }
}

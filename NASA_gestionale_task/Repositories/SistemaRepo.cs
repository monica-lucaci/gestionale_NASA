using NASA_gestionale_task.Models;

namespace NASA_gestionale_task.Repositories
{
    public class SistemaRepo : IRepo<Sistema>
    {
        private readonly NasaContext _context;

        public SistemaRepo(NasaContext context)
        {
            _context = context;
        }

        public bool Create(Sistema entity)
        {
            try
            {
                _context.Sistemi.Add(entity);
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
                Sistema? temp = Get(id);
                if (temp != null)
                {
                    _context.Sistemi.Remove(temp);
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

        public Sistema? Get(int id)
        {
            return _context.Sistemi.Find(id);
        }

        public IEnumerable<Sistema> GetAll()
        {
            return _context.Sistemi.ToList();
        }

        public bool Update(Sistema entity)
        {
            try
            {
                _context.Sistemi.Update(entity);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public Sistema? GetByCodice(string codice)
        {
            try
            {
                return _context.Sistemi.FirstOrDefault(p => p.Codice == codice);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}

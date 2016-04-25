using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsAndRepository.Repositories
{
    public class ArtikulRepository : IRepository<artikul, decimal>
    {
        private readonly VSMDatabaseEntitiesModels _dbContext;

        public ArtikulRepository()
        {
            _dbContext = new VSMDatabaseEntitiesModels();
        }


        public artikul Get(decimal id)
        {
            return _dbContext.artikuls.FirstOrDefault(x => x.id == id);
        }

        public void Save(artikul entity)
        {
            _dbContext.artikuls.Attach(entity);
        }

        public void Delete(artikul entity)
        {
            _dbContext.artikuls.Remove(entity);
        }

        public IEnumerable<artikul> FindAll()
        {
            return _dbContext.artikuls.ToList();
        }

        public IEnumerable<artikul> Take(int count)
        {
            return _dbContext.artikuls.Take(count).ToList();
        }
        public IEnumerable<artikul> Find(string text)
        {
            return _dbContext.artikuls.Where(x => x.Artikul1.StartsWith(text)).ToList();
        }
    }
}

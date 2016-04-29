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

        public IEnumerable<artikul> FindAll(string[] categories, decimal?[] priceRange)
        {
            using (_dbContext)
            {
                IEnumerable<artikul> result = _dbContext.artikuls;
                if (categories != null || priceRange != null)
                {
                    if (categories != null)
                    {
                        result = result.Where(x => categories.Contains(x.Vid));
                    }
                    if (priceRange != null)
                    {
                        result = result.Where(x => x.defprice >= priceRange[0] && x.defprice <= priceRange[1]);
                    }
                }
                return result.ToList();
            }                
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

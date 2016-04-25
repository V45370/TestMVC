using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsAndRepository.Repositories
{
    public class VidRepository
    {           
        private readonly VSMDatabaseEntitiesModels _dbContext;

        public VidRepository()
        {
            _dbContext = new VSMDatabaseEntitiesModels();
        }

        public vid Get(string id)
        {
            return _dbContext.vids.FirstOrDefault(x => x.vid1 == id);
        }

        public IEnumerable<vid> FindAll()
        {
            return _dbContext.vids.ToList();
        }        
    }
}

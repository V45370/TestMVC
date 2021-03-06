﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsAndRepository.Repositories
{
    public interface IRepository<TEntity, in TKey> where TEntity : class
    {
        //TESTING 
        TEntity Get(TKey id);
        void Save(TEntity entity);
        void Delete(TEntity entity);
    }
}

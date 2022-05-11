using Microsoft.EntityFrameworkCore;
using NLayerLab.Data.Abstract;
using NLayerLab.Entities.Concrete;
using NLayerLab.Shared.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayerLab.Data.Concrete.EntityFramework.Repositories
{
    public class EfArticleRepository : EfEntityRepositoryBase<Article>, IArticleRepository
    {
        public EfArticleRepository(DbContext dbContext) : base(dbContext) // added for dbcontext
        {
        }
    }
}

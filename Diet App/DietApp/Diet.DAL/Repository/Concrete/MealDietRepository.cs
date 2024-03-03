using Diet.DAL.Context.EF;
using Diet.DAL.Entites.Concrete;
using Diet.DAL.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.DAL.Repository.Concrete
{
    public class MealDietRepository : GenericRepository<MealDietRecord>
    {
        private DiyetDbContext _dbContext;
        public MealDietRepository(DiyetDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}

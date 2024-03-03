using Diet.DAL.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.DAL.Entites.Concrete
{
    public class Repast : BaseEntity
    {

        public string Name { get; set; }

        public virtual List<MealDietRecord> MealDietRecord { get; set; }


    }
}

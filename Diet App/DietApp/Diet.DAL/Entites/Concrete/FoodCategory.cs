using Diet.DAL.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.DAL.Entites.Concrete
{
    public class FoodCategory : BaseEntity
    {

        public string Name { get; set; }

        public virtual List<Nutrient> Nutrients { get; set; }


    }
}

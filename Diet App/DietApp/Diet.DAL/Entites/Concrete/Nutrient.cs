using Diet.DAL.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Diet.DAL.Entites.Concrete
{
    public class Nutrient : BaseEntity
    {
        public string Name { get; set; }
        public double Calorie { get; set; }
        public byte[] Picture { get; set; }
        public int FoodCategoryId { get; set; }
        public virtual FoodCategory FoodCategory { get; set; }
        public virtual List<MealDietRecord> MealDietRecord { get; set; }

    }
}

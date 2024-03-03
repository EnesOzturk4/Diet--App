using Diet.DAL.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.DAL.Entites.Concrete
{
    public class MealDietRecord : BaseEntity
    {
        public int UserId { get; set; }
        public int NutrientId { get; set; }
        public int RepastId { get; set; }
        public float Portion { get; set; }
        public DateTime DateTime { get; set; }
        public virtual User User { get; set; }
        public virtual Nutrient Nutrient { get; set; }
        public virtual Repast Repast { get; set; }
    }
}

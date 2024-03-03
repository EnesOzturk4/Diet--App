using Diet.DAL.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.BLL.Model
{
    public class MealDietRecordViewModel
    {
        public int Id { get; set; }
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

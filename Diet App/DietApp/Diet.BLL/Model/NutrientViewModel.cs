using Diet.DAL.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.BLL.Model
{
    public class NutrientViewModel
    {
        public int FoodCategoryId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Calorie { get; set; }
        public byte[] Picture { get; set; }


    }
}

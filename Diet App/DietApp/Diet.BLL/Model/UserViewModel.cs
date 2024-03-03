using Diet.DAL.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.BLL.Model
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public float Weight { get; set; }
        public float Size { get; set; }
        public bool IsAdmin { get; set; }
        public virtual List<MealDietRecord> MealDietRecords { get; set; }
    }
}

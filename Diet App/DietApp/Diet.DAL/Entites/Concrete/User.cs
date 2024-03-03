using Diet.DAL.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.DAL.Entites.Concrete
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public float Weight { get; set; }
        public float Size { get; set; }
        public bool IsAdmin { get; set; } = false;
        public virtual List<MealDietRecord> MealDietRecords { get; set; }


    }
}

using Diet.DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.DAL.Entites.Abstract
{
    public interface IEntity
    {

        int Id { get; set; }
        DateTime Created { get; set; }
        DateTime? Modified { get; set; }
        DateTime? Deleted { get; set; }
        DataStatus DataStatus { get; set; }
    }
}

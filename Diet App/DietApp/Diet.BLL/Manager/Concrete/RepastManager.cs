﻿using Diet.BLL.Manager.Abstarct;
using Diet.BLL.Model;
using Diet.DAL.Context.EF;
using Diet.DAL.Entites.Concrete;
using Diet.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.BLL.Manager.Concrete
{
    public class RepastManager : GenaricManager<RepastViewModel,Repast>
    {
        public RepastManager()
        {
            _repository = new RepastRepository(new DiyetDbContext());
        }
    }
}

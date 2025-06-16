using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Context;
using Tekstile.DAL.Repositories.Interfaces;
using Tekstile.Entities.Data;

namespace Tekstile.DAL.Repositories.Services
{
    public class RaporService : IRaporRepo
    {
        MyDbContext _db;
        public RaporService(MyDbContext context)
        {
            _db = context;
            
        }
        public List<Siparisler> Listele()
        {
            var list = _db.Siparisler.ToList();
            return list;
        }
    }
}

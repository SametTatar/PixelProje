using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPlus.Core
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> Query();
        T Find(int id);
        List<T> List();
        bool Update(T ent);
        bool Delete(T id);
        bool Create(T ent);
        DbSet<T> Set();
    }
}

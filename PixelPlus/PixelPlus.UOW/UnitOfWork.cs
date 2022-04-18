using PixelPlus.Core.Absctract;
using PixelPlus.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPlus.UOW
{
    public class UnitOfWork:IUnitOfWork
    {
        Context _db;
        public UnitOfWork(Context db,IFaturaRepos faturaRepos,IAboneRepos aboneRepos)
        {
            _db = db;
            _aboneRepos = aboneRepos;
            _faturaRepos = faturaRepos;
        }
        public IFaturaRepos _faturaRepos { get;private set; }
        public IAboneRepos _aboneRepos { get;private set; }
        public void save()
        {
            _db.SaveChanges();
        }
    }
}

using PixelPlus.Core.Absctract;
using PixelPlus.DAL;
using PixelPlus.ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPlus.Core.Concrete
{
    public class FaturaRepos:BaseRepository<Fatura>,IFaturaRepos
    {
        public FaturaRepos(Context db):base(db)
        {

        }
    }
}

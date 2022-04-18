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
    public class AboneRepos:BaseRepository<Abone>,IAboneRepos
    {
        public AboneRepos(Context db):base(db)
        {

        }

        public List<AboneLists> AboneLists()
        {
            return Set().Select(a => new AboneLists
            {
                AboneId = a.AboneId,
                AboneName = a.AboneName,
                AbonelikDurumu = a.AbonelikDurumu,
                Depozito = a.Depozito,
                //FaturaId = a
                //FaturaTutar = a.faturas.FaturaTutar,
                //FaturaDurumu = a.faturas.FaturaDurumu,
                //FaturaTarih = a.faturas.FaturaTarih
            }).ToList();


        }

    }
}

using PixelPlus.Core.Absctract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPlus.UOW
{
    public interface IUnitOfWork
    {
        IFaturaRepos _faturaRepos { get; }
        IAboneRepos _aboneRepos { get; }
        void save();
    }
}

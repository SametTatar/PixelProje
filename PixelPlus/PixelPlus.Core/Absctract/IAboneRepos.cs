﻿using PixelPlus.ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPlus.Core.Absctract
{
    public interface IAboneRepos:IBaseRepository<Abone>
    {
        List<AboneLists> AboneLists();
        
    }
}

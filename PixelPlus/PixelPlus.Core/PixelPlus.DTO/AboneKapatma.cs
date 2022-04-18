using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPlus.Core.PixelPlus.DTO
{
    public class AboneKapatma
    {
        public int AboneId { get; set; }
        public string? AboneName { get; set; }
        public bool AbonelikDurumu { get; set; }
        public int Depozito { get; set; }
        public int FaturaId { get; set; }
        public int FaturaTutar { get; set; }
        public bool FaturaDurumu { get; set; }
    }
}

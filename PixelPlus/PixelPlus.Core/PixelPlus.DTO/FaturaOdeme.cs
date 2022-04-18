using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPlus.Core.PixelPlus.DTO
{
    public class FaturaOdeme
    {
        public int AboneId { get; set; }
        public string? AboneName { get; set; }
        public int Depozito { get; set; }
        public int AboneBakiye { get; set; }
        public int FaturaId { get; set; }
        public int FaturaTutar { get; set; }
        public DateTime FaturaTarih { get; set; }
        public bool FaturaDurumu { get; set; }
    }
}

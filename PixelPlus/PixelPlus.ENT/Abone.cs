using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPlus.ENT
{
    public class Abone
    {
        public Abone()
        {
            Faturas=new HashSet<Fatura>();
        }
        [Key]
        public int AboneId { get; set; }
        public string ?AboneName { get; set; }
        public int Depozito { get; set; }
        public int AboneBakiye { get; set; }
        public bool AbonelikDurumu { get; set; }
        public ICollection<Fatura>? Faturas { get; set; }
        

    }
    
}

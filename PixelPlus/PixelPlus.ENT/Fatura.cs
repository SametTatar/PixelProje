using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPlus.ENT
{
    public class Fatura
    {
        
        [Key]
        public int FaturaId { get; set; }
        public int FaturaTutar { get; set; }
        public DateTime FaturaTarih { get; set; }
        public bool FaturaDurumu { get; set; }
        public int AboneId { get; set; }
        [ForeignKey("AboneId")]
        public Abone ?Abone { get; set; }
        public Fatura ?Faturaa { get; set; }
        

    }

    
}

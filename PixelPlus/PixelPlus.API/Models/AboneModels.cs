namespace PixelPlus.API.Models
{
    public class AboneModels
    {
        public int AboneId { get; set; }
        public string? AboneName { get; set; }
        public int Depozito { get; set; }
        public int AboneBakiye { get; set; }
        public bool AbonelikDurumu { get; set; }
        public int FaturaId { get; set; }
    }
}

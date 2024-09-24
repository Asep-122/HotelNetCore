using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hotel.Data
{
    public partial class TblMasterRoom d
    {
        public int Id { get; set; }
        public string TipeKamar { get; set; }
        public string UkuranKamar { get; set; }
        public string TipeRanjang { get; set; }
        public string Tamu { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public decimal? Price { get; set; }
        public string FasilitasKamar { get; set; }
        public string FasilitasPublik { get; set; }
        public string FasilitasBisnis { get; set; }
        public string FasilitasTransportasi { get; set; }
        public string FasilitasUmum { get; set; }
        public string FasilitasMakanan { get; set; }
        public string ServiceHotel { get; set; }
    }
}

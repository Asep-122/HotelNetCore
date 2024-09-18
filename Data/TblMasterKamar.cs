using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hotel.Data
{
    public partial class TblMasterKamar
    {
        public string KdKamar { get; set; }
        public string TipeKamar { get; set; }
        public string UkuranKamar { get; set; }
        public string TipeRanjang { get; set; }
        public string Tamu { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public decimal? Price { get; set; }
        public int FasilitasKamar { get; set; }
        public int FasilitasPublik { get; set; }
        public int FasilitasBisnis { get; set; }
        public int FasilitasTransportasi { get; set; }
        public int FasilitasUmum { get; set; }
        public int FasilitasMakanan { get; set; }
        public string ServiceHotel { get; set; }
    }
}

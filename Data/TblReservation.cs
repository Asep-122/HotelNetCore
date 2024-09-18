using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hotel.Data
{
    public partial class TblReservation
    {
        public string KdReservation { get; set; }
        public string Nik { get; set; }
        public string KartuPelajar { get; set; }
        public string Nama { get; set; }
        public string JenisKelamin { get; set; }
        public string Pekerjaan { get; set; }
        public string KewargaNegaraan { get; set; }
        public string StatusPribadi { get; set; }
        public string Alamat { get; set; }
        public DateTime? TglReservasi { get; set; }
        public int KodeKamar { get; set; }
        public DateTime? StartFrom { get; set; }
        public DateTime? EndTo { get; set; }
        public string User { get; set; }
        public string TipePemabayaran { get; set; }
        public string StatusReservation { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int KdPajak { get; set; }
    }
}

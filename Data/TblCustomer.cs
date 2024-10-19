using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hotel.Data
{
    public partial class TblCustomer
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public string JenisKelamin { get; set; }
        public string Pekerjaan { get; set; }
        public string KewargaNegaraan { get; set; }
        public string StatusPribadi { get; set; }
        public string Alamat { get; set; }
        public DateTime? TglLahir { get; set; }
        public string TempatLahir { get; set; }
        public string Agama { get; set; }
    }
}

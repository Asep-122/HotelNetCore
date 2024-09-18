using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Hotel.Data;

namespace Hotel.Models.Reservation
{
    public class CreateEditViewModel
    {
        public IEnumerable<TblReservation> ListReservation { get; set; }
        public List<TblMasterKamar> ListKamar { get; set; }

        public string KdReservation { get; set; }
        public string Nik { get; set; }
        public string KartuPelajar { get; set; }
        [Required(ErrorMessage = "Please provide a valid Nama", AllowEmptyStrings = false)]
        public string Nama { get; set; }
        [Required(ErrorMessage = "Please provide a valid Jenis Kelamin",AllowEmptyStrings =false)]
        public string JenisKelamin { get; set; }
        [Required(ErrorMessage = "Please provide a valid Pekerjaan")]
        public string Pekerjaan { get; set; }
        [Required(ErrorMessage = "Please provide a valid Warga Negara")]
        public string KewargaNegaraan { get; set; }
        [Required(ErrorMessage = "Please provide a valid Agama")]
        public string Agama { get; set; }
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

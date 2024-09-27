using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models.Customer
{
    public class CreateEditViewModel
    {
        [Required]
        public string Nik { get; set; }
        public string KartuPelajar { get; set; }
        public string Nama { get; set; }
        [Display(Name ="Jenis Kelamin")]
        public string JenisKelamin { get; set; }
        public string Pekerjaan { get; set; }
        public string KewargaNegaraan { get; set; }
        public string StatusPribadi { get; set; }
        public string Alamat { get; set; }
        [Display(Name ="Tgl Lahir")]
        public DateTime? TglLahir { get; set; }
        [Display(Name ="Tempat Lahir")]
        public string TempatLahir { get; set; }
        public string Agama { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models.Customer
{
    public class CreateEditViewModel
    {
        [Required(ErrorMessage = "Nik wajib diisi")]
        public string Nik { get; set; }

        [Required(ErrorMessage = "Nama wajib diisi")]
        public string Nama { get; set; }

        [Required(ErrorMessage = "Jenis Kelamin wajib diisi")]
        [Display(Name ="Jenis Kelamin")]
        public string JenisKelamin { get; set; }

        [Required(ErrorMessage = "Pekerjaan wajib diisi")]
        public string Pekerjaan { get; set; }

        [Required(ErrorMessage = "Kewarga negaraan wajib diisi")]
        [Display(Name = "Warga Negara")]
        public string KewargaNegaraan { get; set; }

        [Required(ErrorMessage = "Status wajib diisi")]
        [Display(Name = "Status")]
        public string StatusPribadi { get; set; }

        [Required(ErrorMessage = "Alamat wajib diisi")]
        public string Alamat { get; set; }

        [Required(ErrorMessage = "Tanggal Lahir wajib diisi")]
        [Display(Name ="Tgl Lahir")]
        public DateTime? TglLahir { get; set; }
        [Display(Name ="Tempat Lahir")]
        public string TempatLahir { get; set; }

        [Required(ErrorMessage = "Agama wajib diisi")]
        public string Agama { get; set; }
    }
}

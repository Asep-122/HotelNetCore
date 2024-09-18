using System;
using System.Collections.Generic;
using Hotel.Data;


namespace Hotel.Models.Fasilitas
{
    public class FasilitasEditViewModels
    {

        public IEnumerable<TblFasilitasBisinis> FasilitasBisnis { get; set; }
        public IEnumerable<TblFasilitasKamar> FasilitasKamar { get; set; }
        public IEnumerable<TblFasilitasUmum> FasilitasUmum { get; set; }
        public IEnumerable<TblFasilitasMakanan> FasilitasMakanan { get; set; }
        public IEnumerable<TblFasilitasTransportasi> FasilitasTransportasi { get; set; }
        public IEnumerable<TblFasilitasPublik> FasilitasPublik { get; set; }
        public int Id { get; set; }
        public string JenisFasilitas { get; set; }
        public string Description { get; set; }

    }
}
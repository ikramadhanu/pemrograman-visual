using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostFoundTrackerApp.Repositories;

namespace LostFoundTrackerApp.Controllers
{
    public class KlaimBarangController
    {
        private readonly klaimBarangRepository repo;

        public KlaimBarangController()
        {
            repo = new klaimBarangRepository();
        }

        public bool SimpanKlaim(string id, string bukti, string kontak, string nama, DateTime tanggal)
        {
            return repo.UpdateKlaimBarang(id, bukti, kontak, nama, tanggal);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostFoundTrackerApp.Repositories;

namespace LostFoundTrackerApp.Controllers
{
    public class LaporanHilangController
    {
        private readonly laporanHilangRepository repo;

        public LaporanHilangController()
        {
            repo = new laporanHilangRepository();
        }

        public bool SimpanLaporan(string name, string address, string description, DateTime dateFound, string location)
        {
            return repo.InsertLaporan(name, address, description, dateFound, location);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostFoundTrackerApp.Repositories;

namespace LostFoundTrackerApp.Controllers
{
    public class ListLaporanController
    {
        private readonly listLaporanRepository repo;

        public ListLaporanController()
        {
            repo = new listLaporanRepository();
        }

        public List<Dictionary<string, string>> AmbilSemuaLaporan()
        {
            return repo.GetLaporanList();
        }
        public bool HapusLaporan(string id)
        {
            return repo.DeleteLaporan(id);
        }
    }
}

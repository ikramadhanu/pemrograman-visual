using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostFoundTrackerApp.Repositories;

namespace LostFoundTrackerApp.Controllers
{
    public class ListBarangController
    {
        private readonly listBarangRepository repo;

        public ListBarangController()
        {
            repo = new listBarangRepository();
        }

        public List<Dictionary<string, string>> AmbilSemuaBarang()
        {
            return repo.GetAllBarang();
        }

        public List<Dictionary<string, string>> CariBarang(string keyword)
        {
            return repo.SearchBarang(keyword);
        }
    }
}

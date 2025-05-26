using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostFoundTrackerApp.Repositories;

namespace LostFoundTrackerApp.Controllers
{
    public class ListKlaimController
    {
        private readonly listKlaimRepository repo;

        public ListKlaimController()
        {
            repo = new listKlaimRepository();
        }

        public List<Dictionary<string, string>> AmbilSemuaKlaim()
        {
            return repo.GetKlaimList();
        }

        public bool HapusKlaim(string id)
        {
            return repo.DeleteKlaim(id);
        }
    }
}

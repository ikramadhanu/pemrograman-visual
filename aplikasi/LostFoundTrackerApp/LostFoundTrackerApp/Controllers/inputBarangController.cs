using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostFoundTrackerApp.Repositories;

namespace LostFoundTrackerApp.Controllers
{
    public class InputBarangController
    {
        private readonly inputBarangRepository repo;

        public InputBarangController()
        {
            repo = new inputBarangRepository();
        }

        public bool SimpanBarang(string name, string description, string location, string founder, DateTime dateFound)
        {
            return repo.InsertBarang(name, description, location, founder, dateFound);
        }
    }
}

using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();


        // GET ALL: Category
        public List<Zone> GetAll()
        {
            return _context.Zone.ToList();
        }

        // TO DO: Add ‘Get By Id’
        // TO DO: Add ‘Create’
        // TO DO: Add ‘Edit’
        // TO DO: Add ‘Delete’
        // TO DO: Add ‘Exists’
    }
}


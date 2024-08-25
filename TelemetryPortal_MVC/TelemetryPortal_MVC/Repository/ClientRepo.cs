using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TelemetryPortal_MVC.Repository
{
	public class ClientRepo : GenericRepo<Client>, IClientRepo
	{
        public ClientRepo(TechtrendsContext context) : base(context)
        {

        }

        public Client GetMostRecentClient()
        {
            return _context.Clients.OrderByDescending(client => client.DateOnboarded).FirstOrDefault();
        }
    }
}

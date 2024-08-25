using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repository
{
    public interface IClientRepo: IGenericRepo<Client>
    {
        Client GetMostRecentClient();
    }
}

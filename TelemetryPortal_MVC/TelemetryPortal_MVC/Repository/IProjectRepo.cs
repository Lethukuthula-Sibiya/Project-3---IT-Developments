using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repository
{
    public interface IProjectRepo: IGenericRepo<Project>
    {
        Project GetMostRecentProject();
    }
}

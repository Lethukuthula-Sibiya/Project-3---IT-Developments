using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TelemetryPortal_MVC.Repository
{
	public class ProjectRepo : GenericRepo<Project>, IProjectRepo
	{
		public ProjectRepo(TechtrendsContext context) : base(context) { 
		
		}

		public Project GetMostRecentProject()
		{
			return _context.Projects.OrderByDescending(project => project.ProjectCreationDate).FirstOrDefault();
		}
	}
}

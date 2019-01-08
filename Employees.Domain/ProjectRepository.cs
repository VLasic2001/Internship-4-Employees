using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Data;

namespace Employees.Domain
{
    public class ProjectRepository
    {
        public List<Project> Projects { get; set; }

        public ProjectRepository()
        {
            SeedData();
        }

        public void SeedData()
        {
            Projects = new List<Project>()
            {
                new Project("DUMP Days", new Dictionary<Employee, int>(), new DateTime(2018, 6, 10),
                    new DateTime(2019, 6, 10)),
                new Project("University competitions", new Dictionary<Employee, int>(), new DateTime(2019, 1, 10),
                    new DateTime(2019, 6, 10)),
                new Project("DUMP Internship", new Dictionary<Employee, int>(), new DateTime(2019, 2, 10),
                    new DateTime(2019, 6, 10))
            };
        }

        public List<Project> GetAllItems() => Projects;
    }
}

using System;
using System.Collections.Generic;
using Employees.Data.Classes;

namespace Employees.Domain.Repositories
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
                new Project("DUMP Days", new Dictionary<Employee, int>(), new DateTime(2018, 12, 10),
                    new DateTime(2018, 6, 10)),
                new Project("University competitions", new Dictionary<Employee, int>(), new DateTime(2019, 1, 10),
                    new DateTime(2019, 6, 10)),
                new Project("DUMP Internship", new Dictionary<Employee, int>(), new DateTime(2019, 2, 10),
                    new DateTime(2019, 6, 10))
            };
        }

        public List<Project> GetAllItems() => Projects;

        public bool IsListFilled()
        {
            return Projects.Count > 0;
        }

        public void RemoveProjectFromRepository(Project projectToDelete) => Projects.Remove(projectToDelete);

        public void AddProjectToRepository(Project projectToADd) => Projects.Add(projectToADd);

        public void EditProjectInRepository(Project projectToDelete, Project projectToAdd)
        {
            Projects.Remove(projectToDelete);
            Projects.Add(projectToAdd);
        }
    }
}

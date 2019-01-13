using System;
using System.Collections.Generic;
using Employees.Data.Enums;

namespace Employees.Data.Classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Oib { get; set; }
        public Jobs Job { get; set; }
        public Dictionary<Project, int> ProjectsAndWorkHours { get; set; }

        public Employee(string firstName, string lastName, DateTime dateOfBirth, string oib, Jobs job, Dictionary<Project, int> projectsAndWorkHours)
        {
            ProjectsAndWorkHours = new Dictionary<Project, int>();
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Oib = oib;
            Job = job;
            AddProjects(projectsAndWorkHours);
        }

        public override string ToString() => $"{FirstName} {LastName}, {DateOfBirth:d}, {Oib}, {Job}";

        private void AddProjects(Dictionary<Project, int> projectsAndWorkHours)
        {
            foreach (var project in projectsAndWorkHours.Keys)
            {
                ProjectsAndWorkHours.Add(project, projectsAndWorkHours[project]);
            }
        }

        public void RemoveProject(Project projectToRemove)
        {
            ProjectsAndWorkHours.Remove(projectToRemove);
        }

        public void AddProject(Project projectToAdd, int numberOfHours)
        {
            ProjectsAndWorkHours.Add(projectToAdd, numberOfHours);
        }
    }
}

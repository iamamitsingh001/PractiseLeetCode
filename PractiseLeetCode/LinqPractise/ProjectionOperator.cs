using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseLeetCode.LinqPractise
{
    public class ProjectionOperator
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Subjects { get; set; }

        public IEnumerable<ProjectionOperator> GetAllStudents()
        {
            return new List<ProjectionOperator>
            { 
                new ProjectionOperator { Name = "Amit Singh", Description = "Amit Singh description", Subjects = new List<string> { "ASP.Net", "ASP.Net Core" } },
                new ProjectionOperator { Name = "Amit Singh 1", Description = "Amit Singh description 1", Subjects = new List<string> { "java", "c#" } },
                new ProjectionOperator { Name = "Amit Singh 2", Description = "Amit Singh description 2", Subjects = new List<string> { "MSSQL", "ADO .NET" } }
            };
    }
}
}

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseLeetCode.LinqPractise
{
    public class LinqProgram
    {
        public static void Main(string[] args)
        {
            AggregateOperators aggregateOperators = new AggregateOperators();
            Console.WriteLine("From Min Function : " + aggregateOperators.GetMinUsingLinq() + " From Logic : " + aggregateOperators.GetMinUsingLogic());
            Console.WriteLine("From Even Min Function : " + aggregateOperators.GetEvenMinFromLinq() + " From Logic : " + aggregateOperators.GetEvenMinFromLogic());
            Console.WriteLine("From Max Function : " + aggregateOperators.GetMaxFromLinq() + " From Logic : " + aggregateOperators.GetMaxFromLogic());
            Console.WriteLine("From Even Min Function : " + aggregateOperators.GetEvenMaxFromLinq() + " From Logic : " + aggregateOperators.GetEvenMaxFromLogic());
            Console.WriteLine("Get all countries in a single iteration " + aggregateOperators.GetCommaSeparatedCountries());
            ProjectionOperator projectionOperator = new ProjectionOperator();
            var subjects = projectionOperator.GetAllStudents().SelectMany(s => s.Subjects).Distinct();
            foreach (var item in subjects)
            {
                Console.WriteLine(item);
            }

            //Get students name along with all the subjects 
            var result = from student in projectionOperator.GetAllStudents()
                         from subject in student.Subjects
                         select new { StudentName = student.Name, Subject = subject };

            foreach (var item in result)
            {
                Console.WriteLine(item.StudentName + ", " + item.Subject);
            }

            Console.WriteLine("From Linq Select All");
            result = projectionOperator.GetAllStudents().SelectMany(s => s.Subjects, (student, subject) =>
            new { StudentName= student.Name, Subject = subject});

            foreach (var item in result)
            {
                Console.WriteLine(item.StudentName + ", " + item.Subject);
            }

            Console.ReadLine();
        }
    }
}

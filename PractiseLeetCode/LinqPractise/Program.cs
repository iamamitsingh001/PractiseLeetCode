using System;
using System.Collections.Generic;
using System.Linq;

namespace PractiseLeetCode.LinqPractise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool continueDecider = false;
            #region
            do
            {
                Console.WriteLine("Please enter the page number between 1 to 4");
                if (int.TryParse(Console.ReadLine(), out var PageNumber))
                {
                    if (PageNumber >= 1 && PageNumber <= 4)
                    {
                        int PageSize = 3;
                        Student student = new Student();
                        var result = student.GetStudentDetails().Skip((PageNumber - 1) * PageSize).Take(PageSize);
                        Console.WriteLine("------------------ Result ------------------");
                        foreach (var item in result)
                        {
                            Console.WriteLine(item.Id + "\t" + item.Name + "\t" + item.TotalMarks);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Page Number must be in integer between 1 to 4");
                    }
                }
                else
                {
                    Console.WriteLine("Page Number must be in integer between 1 to 4");
                }
                Console.WriteLine("Would you like to view the other pages as well ? Type Yes to continue...");
                continueDecider = Console.ReadLine().ToLower() == "yes";
            } while (continueDecider);
            #endregion
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }

        public List<Student> GetStudentDetails()
        {
            return new List<Student>
            {
            new Student(){ Id = 1, Name= "Amit Singh", TotalMarks= 81},
            new Student(){ Id = 2, Name= "Supriya Singh", TotalMarks= 90},
            new Student(){ Id = 3, Name= "Pihu Singh", TotalMarks= 100},
            new Student(){ Id = 4, Name= "Sumit Singh", TotalMarks= 85},
            new Student(){ Id = 5, Name= "Sanjeev Singh", TotalMarks= 89},
            new Student(){ Id = 6, Name= "Kavita Singh", TotalMarks= 87},
            new Student(){ Id = 7, Name= "Harsh Singh", TotalMarks= 82},
            new Student(){ Id = 8, Name= "Muskan Singh", TotalMarks= 83},
            new Student(){ Id = 9, Name= "Shaurya Singh", TotalMarks= 84},
            new Student(){ Id = 10, Name= "Ayush Singh", TotalMarks= 86},
            new Student(){ Id = 11, Name= "Lucky Singh", TotalMarks= 88}};
        }

    }
}
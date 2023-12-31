using PractiseLeetCode.DesignPattern.AbstractFactory.AbstractInterface;
using PractiseLeetCode.DesignPattern.AbstractFactory.Client;
using PractiseLeetCode.DesignPattern.AbstractFactory.ConcreteFactory;
using PractiseLeetCode.DesignPattern.Factory;
using PractiseLeetCode.DSLinkedList;
using System;

namespace PractiseLeetCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedListWithGenerics<string> linkedList = new LinkedListWithGenerics<string>();
            linkedList.AddLast("First");
            linkedList.AddLast("Second");
            linkedList.AddLast("Third");
            linkedList.AddFirst("1");
            linkedList.ReadAll();
            #region Very Important
            //Console.WriteLine("Enter EmployeeType");
            //Employee employee = new Employee();
            //employee.EmployeeType = Convert.ToInt32(Console.ReadLine());
            //#region For Abstract Factory Design Pattern
            //IComputerFactory computerFactory = new EmployeeSystemFactory().Create(employee);
            //EmployeeSystemManager employeeSystemManager = new EmployeeSystemManager(computerFactory);
            //employee.SystemDetails = employeeSystemManager.GetSystemDetails();
            //Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(employee));
            #endregion
            #region For Factory Method Design Pattern
            //BaseEmployeeFactory employeeFactory = new EmployeeManagerFactoryNew().CreateFactory(employee);
            //employee = employeeFactory.CalculateSalary();
            //Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(employee));
            #endregion
            #region For Factory Design Pattern
            //EmployeeManagerFactory factory = new EmployeeManagerFactory();
            //IEmployeeManager classManager = factory.GetClassDetails(employee.EmployeeType);
            //Console.WriteLine("Left Value : "+classManager.GetHourlyPay()+" Right Value : "+classManager.GetBonus());
            #endregion
            Console.ReadLine();
        }
    }
}

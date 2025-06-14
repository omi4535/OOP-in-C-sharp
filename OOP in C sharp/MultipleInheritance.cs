using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_in_C_sharp
{

//    Employee with Multiple Roles
//Problem Statement:
//In a corporate system, employees can have multiple responsibilities.One might be a developer and a tester, another might be a manager and a developer.
//Design a flexible system using interfaces to represent different roles.Implement a TechLead class that acts as both a manager and a developer.

//Requirements:
//Create interfaces for IManager, IDeveloper, and ITester.
//Demonstrate role-specific behavior in implementation.

    public interface employee
    {
        public string Id { get; set; }
        public string Name { get; set; }   
     
        void GetEmpDetails();
    }
    interface IManger :employee
    {
        int GetTeamMemberCount();
        void CounduunctMeet();
        void AssingTask();
        void Evaluate();

        void WriteCode();


    }
     interface IDev :employee
    {
         void WriteCode();
         void FixBug();
         void ReviewCode();

    }

    interface Itest : employee
    {
        void WriteTestCases();
        void ExecuteTest();
    }

    class Devloper : IDev
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Devloper(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public void WriteCode()
        {
            Console.WriteLine(Id + " Write code by dev");
        }
        public void FixBug()
        {
            Console.WriteLine(Name + " Fixes bug by dev");
        }
        public void ReviewCode()
        {
            Console.WriteLine(Name + " Reviews code by dev");
        }
        public void GetEmpDetails()
        {
            Console.WriteLine(" Details code by dev");
        }
    }

    class Tester : Itest,employee
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Tester(string id, string name)
        {
            Id = id; Name = name;
        }
        public void ExecuteTest()
        {
            Console.WriteLine(Name + " ExecuteTest");
        }

        public void WriteTestCases()
        {
            Console.WriteLine(Name + " WriteTest");
        }
        public void GetEmpDetails()
        {
            Console.WriteLine(" Details code by test");
        }
    }

    class TechLead : IManger, IDev
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public TechLead(string id, string name)
        {
            Id = id;
            Name = name;
        }

        // ✅ Implicit implementation of IManager methods
        public void AssingTask()
        {
            Console.WriteLine(Name + " assigns tasks");
        }

        public void CounduunctMeet()
        {
            Console.WriteLine(Name + " conducts meetings");
        }

        public void Evaluate()
        {
            Console.WriteLine(Name + " evaluates performance");
        }

        public int GetTeamMemberCount()
        {
            Console.WriteLine(Name + " returns team member count");
            return 5; // Example value
        }

        // ✅ Implicit implementation of IDev methods
        void IDev.WriteCode()
        {
            Console.WriteLine(Name + " writes code by techlead as dev");
        }

        void IManger.WriteCode()
        {
            Console.WriteLine(Name + " writes code by techlead as manger");
        }

        public void FixBug()
        {
            Console.WriteLine(Name + " fixes bugs");
        }

        public void ReviewCode()
        {
            Console.WriteLine(Name + " reviews code");
        }

        // ✅ Implicit implementation of employee method
        public void GetEmpDetails()
        {
            Console.WriteLine($"TechLead Details - ID: {Id}, Name: {Name}");
        }
    }


    internal class MultipleInheritance
    {
        public static void PerformInheritance()
        {
            Devloper dev = new Devloper("D001", "Dev Dave");
            Tester tester = new Tester("T001", "Test Tina");
            TechLead lead = new TechLead("TL001", "Lead Leo");

            dev.WriteCode();
            dev.FixBug();
            dev.GetEmpDetails();

            tester.ExecuteTest();
            tester.WriteTestCases();
            tester.GetEmpDetails();

            ((IDev)lead).WriteCode();
            ((IManger)lead).WriteCode();
            lead.Evaluate();
            lead.GetEmpDetails();
        }
    }
}

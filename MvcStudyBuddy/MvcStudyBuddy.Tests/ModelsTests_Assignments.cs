using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MvcStudyBuddy.Api.Data;
using System.Collections.Generic;
using MvcStudyBuddy.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MvcStudyBuddy.Tests
{
    [TestClass]
    public class ModelsTests_Assignments
    {
        [TestMethod]
        public void AssignmentsComparing_UseDefaultSort_ListIsOrderedByName()
       {
            List<Assignment> assignments = new List<Assignment>()
            {
                new Assignment
                {
                    ID = 1234,
                    Name = "Deliv. 5",
                    DueDate = System.DateTime.Today.AddDays(3),
                    Description = "Fun stuff"
                },
                new Assignment
                {
                    ID = 2345,
                    Name = "Project 4",
                    DueDate = System.DateTime.Today,
                    Description = "stuff"
                },
                new Assignment
                {
                    ID = 3456,
                    Name = "Psych Study",
                    DueDate = System.DateTime.Today.AddDays(100),
                    Description = "Brain work"
                },
                new Assignment
                {
                    ID = 4567,
                    Name = "Web Assign",
                    DueDate = System.DateTime.Today.AddDays(1),
                    Description = "Math stuff"
                },
            };

            assignments.Sort();

            Assert.AreEqual("Deliv. 5", assignments[0].Name);
        }

        [TestMethod]
        public void AssignmentsComparing_UseDueDateComp_ListIsOrderedDueDateAsc()
        {
            Assignment[] assignments = new Assignment[]
            {
                new Assignment
                {
                    ID = 1234,
                    Name = "Deliv. 5",
                    DueDate = System.DateTime.Today.AddDays(10),
                    Description = "Fun stuff"
                },
                new Assignment
                {
                    ID = 2345,
                    Name = "Project 4",
                    DueDate = System.DateTime.Today,
                    Description = "stuff"
                },
                new Assignment
                {
                    ID = 3456,
                    Name = "Psych Study",
                    DueDate = System.DateTime.Today.AddDays(100),
                    Description = "Brain work"
                },
                new Assignment
                {
                    ID = 4567,
                    Name = "Web Assign",
                    DueDate = System.DateTime.Today.AddDays(1),
                    Description = "Math stuff"
                },
            };

            Array.Sort(assignments, Assignment.AssignmentDueDateAscending());

            Assert.AreEqual(System.DateTime.Today, assignments[0].DueDate);
        }
    }
}

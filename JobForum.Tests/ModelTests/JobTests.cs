using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobForum.Models;

namespace JobForum.TestTools
{
  [TestClass]
  public class JobTests : IDisposable
  {
    public void Dispose()
    {
      Job.ClearAll();
    }

    [TestMethod]
    public void JobConstructor_CreatesInstanceOfJob_Job()
    {
      Job newJob = new Job("test", "test", "test");
      Assert.AreEqual(typeof(Job), newJob.GetType());
    }

    [TestMethod]
    public void GetValues_ReturnsJobValues_String()
    {
      string title = "Pilot";
      string description = "You Sit still and steer a plane";
      string contact = "555-555-5555";
      Job newJob = new Job(title, description, contact);

      Assert.AreEqual(title, newJob.Title);
      Assert.AreEqual(description, newJob.Description);
      Assert.AreEqual(contact, newJob.Contact);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyJobList_JobList()
    {
      List<Job> newList = new List<Job> { };
      List<Job> result = Job.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
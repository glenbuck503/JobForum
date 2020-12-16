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
      Job newJob = new Job("test", "test");
      Assert.AreEqual(typeof(Job), newJob.GetType());
    }
  }
}
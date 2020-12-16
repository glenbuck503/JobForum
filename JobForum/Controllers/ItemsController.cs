using Microsoft.AspNetCore.Mvc;
using JobForum.Models;
using System.Collections.Generic;

namespace JobForum.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      List<Job> allJobs = Job.GetAll();
      return View(allJobs);
    }

    [HttpGet("jobs/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/jobs")]
    public ActionResult Create(string title, string description, string contact)
    {
      Job myJob = new Job(title, description, contact);
      return RedirectToAction("Index");
    }

    [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Job.ClearAll();
      return View();
    }

    [HttpGet("/items/{id}")]
    public ActionResult Show(int id)
    {
      Job foundJob = Job.Find(id);
      return View(foundJob);
    }


  }
}
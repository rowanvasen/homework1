using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using Homework2.Models;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    
   [HttpPost]
    public IActionResult Teams(TeamsModel team)
    {
        if (team.Validate())
        {
            
            var NamesList = team.Names.Split('\n').ToList();
            
            var random = new Random();
            NamesList = NamesList.OrderBy(x => random.Next()).ToList();
            team.GeneratedTeams = new List<List<string>>();
            for (int i = 0; i < NamesList.Count; i += team.TeamSize)
            {
                team.GeneratedTeams.Add(NamesList.Skip(i).Take(team.TeamSize).ToList());
            }

            return View(team);
        }
            
        ViewBag.ErrorMessage = "Invalid input, please review your input and the requirements and try again.";
        return View("Index");
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
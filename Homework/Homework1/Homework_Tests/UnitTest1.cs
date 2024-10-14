using Homework2.Models; 

namespace Homework_Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DoesTeamSizeGiveErrorWhenTooLarge()

    {
        var team = new TeamsModel();
        team.Names = "Rowan\nVasen\nRowan\nVasen\nRowan\nVasen\nRowan\nVasen\nRowan\nVasen\n";
        team.TeamSize = 11;
        Assert.IsFalse(team.Validate());
    }

    [Test]
    public void DoesTeamSizeGiveErrorWhenTooSmall()
    {
        var team = new TeamsModel();
        team.Names = "Rowan\nVasen\nRowan\nVasen\nRowan\nVasen\nRowan\nVasen\nRowan\nVasen\n";
        team.TeamSize = 0;
        Assert.IsFalse(team.Validate());
    }

    [Test]
    public void DoesTeamSizeGiveTrueWhenCorrect()
    {
        var team = new TeamsModel();
        team.Names = "Rowan\nVasen\nRowan\nVasen\nRowan\nVasen\nRowan\nVasen\nRowan\nVasen\n";
        team.TeamSize = 5;
        Assert.IsTrue(team.Validate());
    }

    [Test]
    public void DoesNameGiveErrorWhenEmpty()
    {
        var team = new TeamsModel();
        team.Names = "";
        team.TeamSize = 5;
        Assert.IsFalse(team.Validate());
    }

    [Test]
    public void DoesNameGiveTrueWhenCorrect()
    {
        var team = new TeamsModel();
        team.Names = "Rowan\nVasen\nRowan\nVasen\nRowan\nVasen\nRowan\nVasen\nRowan\nVasen\n";
        team.TeamSize = 5;
        Assert.IsTrue(team.Validate());
    }


        

}
namespace Homework2.Models;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class TeamsModel
{
    [Required]
    public string? Names { get; set; }

    [Required]
    public int TeamSize { get; set; }

    public List<List<string>>? GeneratedTeams { get; set; }

    public bool Validate()
    {
        if (string.IsNullOrWhiteSpace(Names) || TeamSize <= 0 || TeamSize > 10 || Names.Split('\n').Length < TeamSize)
        {
            return false;
        }
        return true;
    }

}

namespace HeroAPI.Models;

public class Hero
{
    public int id { get; set; }
    public string firstname { get; set; } = null!;
    public string lastname { get; set; } = null!;
    public string heroname { get; set; } = null!;
    public string city { get; set; } = null!;
    public int age { get; set; }
}
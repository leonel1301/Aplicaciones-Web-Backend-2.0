namespace LearningCenter.Infraestructure.Models;

public class User
{
    
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Bicycle> Bicyles { get; set; }
}
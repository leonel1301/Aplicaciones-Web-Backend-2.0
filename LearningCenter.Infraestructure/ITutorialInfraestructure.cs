using LearningCenter.Infraestructure.Models;

namespace LearningCenter.Infraestructure;

public interface ITutorialInfraestructure
{
    List<Tutorial> GetAll();
    
    public bool save(string name);
    public bool update(int id, string name);
    public bool delete(int id);
}